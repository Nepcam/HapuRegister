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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelParents = new System.Windows.Forms.Label();
            this.textBoxParents = new System.Windows.Forms.TextBox();
            this.textBoxGParents = new System.Windows.Forms.TextBox();
            this.labelGrandparents = new System.Windows.Forms.Label();
            this.labelMarae = new System.Windows.Forms.Label();
            this.labelVerifiedPerson = new System.Windows.Forms.Label();
            this.checkedListBoxMarae = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxVerified = new System.Windows.Forms.CheckedListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxRegistered = new System.Windows.Forms.GroupBox();
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
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(139, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 26);
            this.textBoxName.TabIndex = 2;
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
            // textBoxParents
            // 
            this.textBoxParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParents.Location = new System.Drawing.Point(139, 126);
            this.textBoxParents.Name = "textBoxParents";
            this.textBoxParents.Size = new System.Drawing.Size(183, 26);
            this.textBoxParents.TabIndex = 4;
            // 
            // textBoxGParents
            // 
            this.textBoxGParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGParents.Location = new System.Drawing.Point(496, 88);
            this.textBoxGParents.Name = "textBoxGParents";
            this.textBoxGParents.Size = new System.Drawing.Size(183, 26);
            this.textBoxGParents.TabIndex = 5;
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
            // checkedListBoxVerified
            // 
            this.checkedListBoxVerified.FormattingEnabled = true;
            this.checkedListBoxVerified.Items.AddRange(new object[] {
            "Koro Bucky",
            "Uncle Pip",
            "Aunty Hine",
            "Wakatea"});
            this.checkedListBoxVerified.Location = new System.Drawing.Point(139, 172);
            this.checkedListBoxVerified.Name = "checkedListBoxVerified";
            this.checkedListBoxVerified.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxVerified.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(16, 302);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(636, 46);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxRegistered
            // 
            this.groupBoxRegistered.Location = new System.Drawing.Point(16, 386);
            this.groupBoxRegistered.Name = "groupBoxRegistered";
            this.groupBoxRegistered.Size = new System.Drawing.Size(663, 245);
            this.groupBoxRegistered.TabIndex = 14;
            this.groupBoxRegistered.TabStop = false;
            this.groupBoxRegistered.Text = "groupBox1";
            // 
            // FormHapuRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(700, 647);
            this.Controls.Add(this.groupBoxRegistered);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkedListBoxVerified);
            this.Controls.Add(this.checkedListBoxMarae);
            this.Controls.Add(this.labelVerifiedPerson);
            this.Controls.Add(this.labelMarae);
            this.Controls.Add(this.labelGrandparents);
            this.Controls.Add(this.textBoxGParents);
            this.Controls.Add(this.textBoxParents);
            this.Controls.Add(this.labelParents);
            this.Controls.Add(this.textBoxName);
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
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelParents;
        private System.Windows.Forms.TextBox textBoxParents;
        private System.Windows.Forms.TextBox textBoxGParents;
        private System.Windows.Forms.Label labelGrandparents;
        private System.Windows.Forms.Label labelMarae;
        private System.Windows.Forms.Label labelVerifiedPerson;
        private System.Windows.Forms.CheckedListBox checkedListBoxMarae;
        private System.Windows.Forms.CheckedListBox checkedListBoxVerified;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxRegistered;
    }
}

