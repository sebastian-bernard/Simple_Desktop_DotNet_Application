
namespace SImpleDesktopDotNetApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTowns = new System.Windows.Forms.DataGridView();
            this.dataGridViewRestaurants = new System.Windows.Forms.DataGridView();
            this.labelTownsTable = new System.Windows.Forms.Label();
            this.labelRestaurantsTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTownid = new System.Windows.Forms.Label();
            this.textBoxTownid = new System.Windows.Forms.TextBox();
            this.textBoxTownName = new System.Windows.Forms.TextBox();
            this.labelTownName = new System.Windows.Forms.Label();
            this.labelRestaurantTid = new System.Windows.Forms.Label();
            this.labelRestaurantName = new System.Windows.Forms.Label();
            this.textBoxRestaurantTid = new System.Windows.Forms.TextBox();
            this.textBoxRestaurantName = new System.Windows.Forms.TextBox();
            this.labelRestaurantRid = new System.Windows.Forms.Label();
            this.textBoxRestaurantRid = new System.Windows.Forms.TextBox();
            this.labelRestaurantRating = new System.Windows.Forms.Label();
            this.textBoxRestaurantRating = new System.Windows.Forms.TextBox();
            this.townAddButton = new System.Windows.Forms.Button();
            this.townUpdateButton = new System.Windows.Forms.Button();
            this.townDeleteButton = new System.Windows.Forms.Button();
            this.restaurantAddButton = new System.Windows.Forms.Button();
            this.restaurantUpdateButton = new System.Windows.Forms.Button();
            this.restaurantDeleteButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTowns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurants)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTowns
            // 
            this.dataGridViewTowns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTowns.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewTowns.Name = "dataGridViewTowns";
            this.dataGridViewTowns.RowHeadersWidth = 51;
            this.dataGridViewTowns.RowTemplate.Height = 29;
            this.dataGridViewTowns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTowns.Size = new System.Drawing.Size(295, 194);
            this.dataGridViewTowns.TabIndex = 0;
            // 
            // dataGridViewRestaurants
            // 
            this.dataGridViewRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurants.Location = new System.Drawing.Point(431, 48);
            this.dataGridViewRestaurants.Name = "dataGridViewRestaurants";
            this.dataGridViewRestaurants.RowHeadersWidth = 51;
            this.dataGridViewRestaurants.RowTemplate.Height = 29;
            this.dataGridViewRestaurants.Size = new System.Drawing.Size(569, 194);
            this.dataGridViewRestaurants.TabIndex = 0;
            // 
            // labelTownsTable
            // 
            this.labelTownsTable.AutoSize = true;
            this.labelTownsTable.Location = new System.Drawing.Point(12, 25);
            this.labelTownsTable.Name = "labelTownsTable";
            this.labelTownsTable.Size = new System.Drawing.Size(89, 20);
            this.labelTownsTable.TabIndex = 2;
            this.labelTownsTable.Text = "Towns Table";
            // 
            // labelRestaurantsTable
            // 
            this.labelRestaurantsTable.AutoSize = true;
            this.labelRestaurantsTable.Location = new System.Drawing.Point(431, 25);
            this.labelRestaurantsTable.Name = "labelRestaurantsTable";
            this.labelRestaurantsTable.Size = new System.Drawing.Size(124, 20);
            this.labelRestaurantsTable.TabIndex = 2;
            this.labelRestaurantsTable.Text = "Restaurants Table";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // labelTownid
            // 
            this.labelTownid.AutoSize = true;
            this.labelTownid.Location = new System.Drawing.Point(12, 329);
            this.labelTownid.Name = "labelTownid";
            this.labelTownid.Size = new System.Drawing.Size(61, 20);
            this.labelTownid.TabIndex = 3;
            this.labelTownid.Text = "Town Id";
            // 
            // textBoxTownid
            // 
            this.textBoxTownid.Location = new System.Drawing.Point(12, 352);
            this.textBoxTownid.Name = "textBoxTownid";
            this.textBoxTownid.Size = new System.Drawing.Size(58, 27);
            this.textBoxTownid.TabIndex = 4;
            // 
            // textBoxTownName
            // 
            this.textBoxTownName.Location = new System.Drawing.Point(76, 352);
            this.textBoxTownName.Name = "textBoxTownName";
            this.textBoxTownName.Size = new System.Drawing.Size(160, 27);
            this.textBoxTownName.TabIndex = 4;
            // 
            // labelTownName
            // 
            this.labelTownName.AutoSize = true;
            this.labelTownName.Location = new System.Drawing.Point(76, 329);
            this.labelTownName.Name = "labelTownName";
            this.labelTownName.Size = new System.Drawing.Size(88, 20);
            this.labelTownName.TabIndex = 3;
            this.labelTownName.Text = "Town Name";
            // 
            // labelRestaurantTid
            // 
            this.labelRestaurantTid.AutoSize = true;
            this.labelRestaurantTid.Location = new System.Drawing.Point(431, 329);
            this.labelRestaurantTid.Name = "labelRestaurantTid";
            this.labelRestaurantTid.Size = new System.Drawing.Size(61, 20);
            this.labelRestaurantTid.TabIndex = 3;
            this.labelRestaurantTid.Text = "Town Id";
            // 
            // labelRestaurantName
            // 
            this.labelRestaurantName.AutoSize = true;
            this.labelRestaurantName.Location = new System.Drawing.Point(597, 329);
            this.labelRestaurantName.Name = "labelRestaurantName";
            this.labelRestaurantName.Size = new System.Drawing.Size(123, 20);
            this.labelRestaurantName.TabIndex = 3;
            this.labelRestaurantName.Text = "Restaurant Name";
            // 
            // textBoxRestaurantTid
            // 
            this.textBoxRestaurantTid.Location = new System.Drawing.Point(431, 352);
            this.textBoxRestaurantTid.Name = "textBoxRestaurantTid";
            this.textBoxRestaurantTid.Size = new System.Drawing.Size(58, 27);
            this.textBoxRestaurantTid.TabIndex = 4;
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new System.Drawing.Point(597, 352);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new System.Drawing.Size(191, 27);
            this.textBoxRestaurantName.TabIndex = 4;
            // 
            // labelRestaurantRid
            // 
            this.labelRestaurantRid.AutoSize = true;
            this.labelRestaurantRid.Location = new System.Drawing.Point(495, 329);
            this.labelRestaurantRid.Name = "labelRestaurantRid";
            this.labelRestaurantRid.Size = new System.Drawing.Size(96, 20);
            this.labelRestaurantRid.TabIndex = 3;
            this.labelRestaurantRid.Text = "Restaurant Id";
            // 
            // textBoxRestaurantRid
            // 
            this.textBoxRestaurantRid.Location = new System.Drawing.Point(495, 352);
            this.textBoxRestaurantRid.Name = "textBoxRestaurantRid";
            this.textBoxRestaurantRid.Size = new System.Drawing.Size(96, 27);
            this.textBoxRestaurantRid.TabIndex = 4;
            // 
            // labelRestaurantRating
            // 
            this.labelRestaurantRating.AutoSize = true;
            this.labelRestaurantRating.Location = new System.Drawing.Point(794, 329);
            this.labelRestaurantRating.Name = "labelRestaurantRating";
            this.labelRestaurantRating.Size = new System.Drawing.Size(52, 20);
            this.labelRestaurantRating.TabIndex = 3;
            this.labelRestaurantRating.Text = "Rating";
            // 
            // textBoxRestaurantRating
            // 
            this.textBoxRestaurantRating.Location = new System.Drawing.Point(794, 352);
            this.textBoxRestaurantRating.Name = "textBoxRestaurantRating";
            this.textBoxRestaurantRating.Size = new System.Drawing.Size(58, 27);
            this.textBoxRestaurantRating.TabIndex = 4;
            // 
            // townAddButton
            // 
            this.townAddButton.Location = new System.Drawing.Point(12, 410);
            this.townAddButton.Name = "townAddButton";
            this.townAddButton.Size = new System.Drawing.Size(94, 29);
            this.townAddButton.TabIndex = 5;
            this.townAddButton.Text = "ADD";
            this.townAddButton.UseVisualStyleBackColor = true;
            this.townAddButton.Click += new System.EventHandler(this.townAddButton_Click);
            // 
            // townUpdateButton
            // 
            this.townUpdateButton.Location = new System.Drawing.Point(126, 410);
            this.townUpdateButton.Name = "townUpdateButton";
            this.townUpdateButton.Size = new System.Drawing.Size(94, 29);
            this.townUpdateButton.TabIndex = 5;
            this.townUpdateButton.Text = "UPDATE";
            this.townUpdateButton.UseVisualStyleBackColor = true;
            this.townUpdateButton.Click += new System.EventHandler(this.townUpdateButton_Click);
            // 
            // townDeleteButton
            // 
            this.townDeleteButton.Location = new System.Drawing.Point(241, 410);
            this.townDeleteButton.Name = "townDeleteButton";
            this.townDeleteButton.Size = new System.Drawing.Size(94, 29);
            this.townDeleteButton.TabIndex = 5;
            this.townDeleteButton.Text = "DELETE";
            this.townDeleteButton.UseVisualStyleBackColor = true;
            this.townDeleteButton.Click += new System.EventHandler(this.townDeleteButton_Click);
            // 
            // restaurantAddButton
            // 
            this.restaurantAddButton.Location = new System.Drawing.Point(416, 409);
            this.restaurantAddButton.Name = "restaurantAddButton";
            this.restaurantAddButton.Size = new System.Drawing.Size(137, 45);
            this.restaurantAddButton.TabIndex = 5;
            this.restaurantAddButton.Text = "ADD";
            this.restaurantAddButton.UseVisualStyleBackColor = true;
            this.restaurantAddButton.Click += new System.EventHandler(this.restaurantAddButton_Click);
            // 
            // restaurantUpdateButton
            // 
            this.restaurantUpdateButton.Location = new System.Drawing.Point(582, 409);
            this.restaurantUpdateButton.Name = "restaurantUpdateButton";
            this.restaurantUpdateButton.Size = new System.Drawing.Size(137, 45);
            this.restaurantUpdateButton.TabIndex = 5;
            this.restaurantUpdateButton.Text = "UPDATE";
            this.restaurantUpdateButton.UseVisualStyleBackColor = true;
            this.restaurantUpdateButton.Click += new System.EventHandler(this.restaurantUpdateButton_Click);
            // 
            // restaurantDeleteButton
            // 
            this.restaurantDeleteButton.Location = new System.Drawing.Point(741, 409);
            this.restaurantDeleteButton.Name = "restaurantDeleteButton";
            this.restaurantDeleteButton.Size = new System.Drawing.Size(137, 45);
            this.restaurantDeleteButton.TabIndex = 5;
            this.restaurantDeleteButton.Text = "DELETE";
            this.restaurantDeleteButton.UseVisualStyleBackColor = true;
            this.restaurantDeleteButton.Click += new System.EventHandler(this.restaurantDeleteButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(912, 425);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(90, 77);
            this.saveChangesButton.TabIndex = 7;
            this.saveChangesButton.Text = "SAVE CHANGES";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 514);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.townDeleteButton);
            this.Controls.Add(this.restaurantDeleteButton);
            this.Controls.Add(this.restaurantUpdateButton);
            this.Controls.Add(this.restaurantAddButton);
            this.Controls.Add(this.townUpdateButton);
            this.Controls.Add(this.townAddButton);
            this.Controls.Add(this.textBoxRestaurantName);
            this.Controls.Add(this.textBoxRestaurantRid);
            this.Controls.Add(this.textBoxRestaurantRating);
            this.Controls.Add(this.textBoxRestaurantTid);
            this.Controls.Add(this.textBoxTownName);
            this.Controls.Add(this.labelRestaurantName);
            this.Controls.Add(this.labelRestaurantRid);
            this.Controls.Add(this.labelRestaurantRating);
            this.Controls.Add(this.textBoxTownid);
            this.Controls.Add(this.labelRestaurantTid);
            this.Controls.Add(this.labelTownName);
            this.Controls.Add(this.labelTownid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRestaurantsTable);
            this.Controls.Add(this.labelTownsTable);
            this.Controls.Add(this.dataGridViewRestaurants);
            this.Controls.Add(this.dataGridViewTowns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTowns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTowns;
        private System.Windows.Forms.DataGridView dataGridViewRestaurants;
        private System.Windows.Forms.Label labelTownsTable;
        private System.Windows.Forms.Label labelRestaurantsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTownid;
        private System.Windows.Forms.TextBox textBoxTownid;
        private System.Windows.Forms.TextBox textBoxTownName;
        private System.Windows.Forms.Label labelTownName;
        private System.Windows.Forms.Label labelRestaurantTid;
        private System.Windows.Forms.Label labelRestaurantName;
        private System.Windows.Forms.TextBox textBoxRestaurantTid;
        private System.Windows.Forms.TextBox textBoxRestaurantName;
        private System.Windows.Forms.Label labelRestaurantRid;
        private System.Windows.Forms.TextBox textBoxRestaurantRid;
        private System.Windows.Forms.Label labelRestaurantRating;
        private System.Windows.Forms.TextBox textBoxRestaurantRating;
        private System.Windows.Forms.Button townAddButton;
        private System.Windows.Forms.Button townUpdateButton;
        private System.Windows.Forms.Button townDeleteButton;
        private System.Windows.Forms.Button restaurantAddButton;
        private System.Windows.Forms.Button restaurantUpdateButton;
        private System.Windows.Forms.Button restaurantDeleteButton;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button saveChangesButton;
    }
}

