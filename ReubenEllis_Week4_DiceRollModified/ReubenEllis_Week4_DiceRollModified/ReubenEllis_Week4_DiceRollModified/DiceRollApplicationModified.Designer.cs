namespace ReubenEllis_Week4_DiceRollModified
{
    partial class DiceRollApplicationModified
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoll = new System.Windows.Forms.Button();
            this.list1stSequence = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list2ndSequence = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSequence1Doubles = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSequence2Doubles = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRoll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRoll.Location = new System.Drawing.Point(458, 192);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(196, 60);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // list1stSequence
            // 
            this.list1stSequence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list1stSequence.Location = new System.Drawing.Point(12, 156);
            this.list1stSequence.Name = "list1stSequence";
            this.list1stSequence.Size = new System.Drawing.Size(440, 389);
            this.list1stSequence.TabIndex = 16;
            this.list1stSequence.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Roll Number";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Dice 1 Value";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dice 2 Value";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dice Total";
            this.columnHeader4.Width = 80;
            // 
            // list2ndSequence
            // 
            this.list2ndSequence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.list2ndSequence.Location = new System.Drawing.Point(660, 156);
            this.list2ndSequence.Name = "list2ndSequence";
            this.list2ndSequence.Size = new System.Drawing.Size(440, 389);
            this.list2ndSequence.TabIndex = 17;
            this.list2ndSequence.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Roll Number";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dice 1 Value";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dice 2 Value";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dice Total";
            this.columnHeader8.Width = 80;
            // 
            // listSequence1Doubles
            // 
            this.listSequence1Doubles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listSequence1Doubles.Location = new System.Drawing.Point(12, 13);
            this.listSequence1Doubles.Name = "listSequence1Doubles";
            this.listSequence1Doubles.Size = new System.Drawing.Size(485, 137);
            this.listSequence1Doubles.TabIndex = 18;
            this.listSequence1Doubles.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "# Double Pairs";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Double Values Results";
            this.columnHeader12.Width = 270;
            // 
            // listSequence2Doubles
            // 
            this.listSequence2Doubles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.listSequence2Doubles.Location = new System.Drawing.Point(615, 13);
            this.listSequence2Doubles.Name = "listSequence2Doubles";
            this.listSequence2Doubles.Size = new System.Drawing.Size(485, 137);
            this.listSequence2Doubles.TabIndex = 19;
            this.listSequence2Doubles.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "# Double Pairs";
            this.columnHeader13.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Double Values Results";
            this.columnHeader14.Width = 270;
            // 
            // DiceRollApplicationModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 566);
            this.Controls.Add(this.listSequence2Doubles);
            this.Controls.Add(this.listSequence1Doubles);
            this.Controls.Add(this.list2ndSequence);
            this.Controls.Add(this.list1stSequence);
            this.Controls.Add(this.btnRoll);
            this.Name = "DiceRollApplicationModified";
            this.Text = "Dice Roll Application";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListView list1stSequence;
        private System.Windows.Forms.ListView list2ndSequence;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listSequence1Doubles;
        private System.Windows.Forms.ListView listSequence2Doubles;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}