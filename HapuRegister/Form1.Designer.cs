namespace HapuRegister
{
    partial class FormHapuRegister
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelParents = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelGrandparents = new System.Windows.Forms.Label();
            this.labelMarae = new System.Windows.Forms.Label();
            this.labelVerifiedPerson = new System.Windows.Forms.Label();
            this.checkedListBoxMarae = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ingoa:";
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.Location = new System.Drawing.Point(257, 9);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(162, 25);
            this.labelFormTitle.TabIndex = 1;
            this.labelFormTitle.Text = "Hapu Register";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 26);
            this.textBox1.TabIndex = 2;
            // 
            // labelParents
            // 
            this.labelParents.AutoSize = true;
            this.labelParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParents.Location = new System.Drawing.Point(12, 126);
            this.labelParents.Name = "labelParents";
            this.labelParents.Size = new System.Drawing.Size(64, 20);
            this.labelParents.TabIndex = 3;
            this.labelParents.Text = "Matua:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(139, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(496, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 26);
            this.textBox3.TabIndex = 5;
            // 
            // labelGrandparents
            // 
            this.labelGrandparents.AutoSize = true;
            this.labelGrandparents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandparents.Location = new System.Drawing.Point(344, 91);
            this.labelGrandparents.Name = "labelGrandparents";
            this.labelGrandparents.Size = new System.Drawing.Size(126, 20);
            this.labelGrandparents.TabIndex = 6;
            this.labelGrandparents.Text = "Kuia and Koro:";
            // 
            // labelMarae
            // 
            this.labelMarae.AutoSize = true;
            this.labelMarae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarae.Location = new System.Drawing.Point(344, 132);
            this.labelMarae.Name = "labelMarae";
            this.labelMarae.Size = new System.Drawing.Size(64, 20);
            this.labelMarae.TabIndex = 7;
            this.labelMarae.Text = "Marae:";
            // 
            // labelVerifiedPerson
            // 
            this.labelVerifiedPerson.AutoSize = true;
            this.labelVerifiedPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerifiedPerson.Location = new System.Drawing.Point(12, 172);
            this.labelVerifiedPerson.Name = "labelVerifiedPerson";
            this.labelVerifiedPerson.Size = new System.Drawing.Size(99, 20);
            this.labelVerifiedPerson.TabIndex = 9;
            this.labelVerifiedPerson.Text = "Verified by:";
            // 
            // checkedListBoxMarae
            // 
            this.checkedListBoxMarae.FormattingEnabled = true;
            this.checkedListBoxMarae.Items.AddRange(new object[] {
            "Rawhiti",
            "Onetahi",
            "Tamatoa",
            "Whakatea"});
            this.checkedListBoxMarae.Location = new System.Drawing.Point(496, 132);
            this.checkedListBoxMarae.Name = "checkedListBoxMarae";
            this.checkedListBoxMarae.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxMarae.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Koro Bucky",
            "Uncle Pip",
            "Aunty Hine",
            "Wakatea"});
            this.checkedListBox1.Location = new System.Drawing.Point(139, 172);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(636, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormHapuRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(700, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkedListBoxMarae);
            this.Controls.Add(this.labelVerifiedPerson);
            this.Controls.Add(this.labelMarae);
            this.Controls.Add(this.labelGrandparents);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelParents);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFormTitle);
            this.Controls.Add(this.labelName);
            this.Name = "FormHapuRegister";
            this.Text = "HAPU REGISTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelParents;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelGrandparents;
        private System.Windows.Forms.Label labelMarae;
        private System.Windows.Forms.Label labelVerifiedPerson;
        private System.Windows.Forms.CheckedListBox checkedListBoxMarae;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}

