using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

namespace SImpleDesktopDotNetApplication
{
    public partial class Form1 : Form
    {
        private readonly string TOWNS_TABLE = "Towns";        
        private readonly string RESTAURANTS_TABLE = "Restaurants";
        private readonly string FK_RESTAURANTS_TOWNS = "FK__Restaurants__Tid__2F10007B";


        private readonly string myConnectionString = "Data Source = DESKTOP-AKPT408; " +
                                                    "Initial Catalog = DB_FoodDelivery_simplified; " +
                                                    "Integrated Security = SSPI";
        private SqlConnection dbConnection;
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter townsDataAdapter, restaurantsDataAdapter;

        private BindingSource townsBinding, 
                             restaurantsBinding;

        private DataRelation dataRelation;

        private void insertNewTownRow(int townId, string townName)
        {
            DataRow newDataRow = dataSet.Tables[TOWNS_TABLE].NewRow();
            newDataRow["Tid"] = townId;
            newDataRow["TownName"] = townName;
            dataSet.Tables[TOWNS_TABLE].Rows.Add(newDataRow);
        }
        /*
        private void deleteTownRow(int townId)
        {
            DataRow rowToDelete = dataSet.Tables[TOWNS_TABLE].Rows.Find(townId);
            if(rowToDelete == null)
                throw new ArgumentException("no town with specified id can be found!");
            rowToDelete.Delete();
        }
        */

        private void deleteTownRow(int townId)
        {
            bool foundAndDeleted = false;
            for(int i=0; i< dataSet.Tables[TOWNS_TABLE].Rows.Count; ++i)
            {                
                if (dataSet.Tables[TOWNS_TABLE].Rows[i]["Tid"].Equals(townId))
                {
                    dataSet.Tables[TOWNS_TABLE].Rows[i].Delete();
                    dataSet.AcceptChanges();
                    foundAndDeleted = true;
                }                    
            }
            if (foundAndDeleted.Equals(false))
                throw new ArgumentException("no town with specified id can be found!");                            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (dbConnection = new SqlConnection(myConnectionString))
            {
                try
                {
                    //INITIALIZE DB
                    dbConnection.Open();
                    townsDataAdapter = new SqlDataAdapter($"SELECT * FROM {TOWNS_TABLE}", dbConnection);
                    restaurantsDataAdapter = new SqlDataAdapter($"SELECT * FROM {RESTAURANTS_TABLE}", dbConnection);

                    townsDataAdapter.Fill(dataSet, TOWNS_TABLE);
                    restaurantsDataAdapter.Fill(dataSet, RESTAURANTS_TABLE);
                    dataRelation = new DataRelation(FK_RESTAURANTS_TOWNS, dataSet.Tables[TOWNS_TABLE].Columns["Tid"],
                                                                        dataSet.Tables[RESTAURANTS_TABLE].Columns["Tid"]);
                    dataSet.Relations.Add(dataRelation);


                    //INITIALIZE UI
                    townsBinding = new BindingSource();
                    townsBinding.DataSource = dataSet;
                    townsBinding.DataMember = TOWNS_TABLE;
                    
                    restaurantsBinding = new BindingSource();
                    restaurantsBinding.DataSource = dataSet;
                    restaurantsBinding.DataMember = RESTAURANTS_TABLE;                    

                    /* LAB 2
                    restaurantsBinding = new BindingSource();
                    restaurantsBinding.DataSource = townsBinding;
                    restaurantsBinding.DataMember = FK_RESTAURANTS_TOWNS;
                    */

                    dataGridViewTowns.DataSource = townsBinding;
                    dataGridViewRestaurants.DataSource = restaurantsBinding;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }

        private void townAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int townId = Int32.Parse(textBoxTownid.Text);
                string townName = textBoxTownName.Text;
                this.insertNewTownRow(townId, townName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void townUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void townDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int townId = Int32.Parse(textBoxTownid.Text);
                this.deleteTownRow(townId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void restaurantAddButton_Click(object sender, EventArgs e)
        {

        }

        private void restaurantUpdateButton_Click(object sender, EventArgs e)
        {

        }     

        private void restaurantDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            using (dbConnection = new SqlConnection(myConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    townsDataAdapter.Update(dataSet, TOWNS_TABLE);
                    restaurantsDataAdapter.Update(dataSet, RESTAURANTS_TABLE);
                    dbConnection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }       
        }

        private void InitializeDB()
        {
        }
    }
}