namespace MUSICFORM
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
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            nameInput = new TextBox();
            surnameInpute = new TextBox();
            birthdayDate = new TextBox();
            MaleButton = new RadioButton();
            FemaleButton = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(545, 24);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(224, 43);
            AddButton.TabIndex = 0;
            AddButton.Text = "add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(653, 295);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(44, 48);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(100, 23);
            nameInput.TabIndex = 2;
            // 
            // surnameInpute
            // 
            surnameInpute.Location = new Point(163, 48);
            surnameInpute.Name = "surnameInpute";
            surnameInpute.Size = new Size(100, 23);
            surnameInpute.TabIndex = 3;
            // 
            // birthdayDate
            // 
            birthdayDate.Location = new Point(281, 48);
            birthdayDate.Name = "birthdayDate";
            birthdayDate.Size = new Size(100, 23);
            birthdayDate.TabIndex = 4;
            // 
            // MaleButton
            // 
            MaleButton.AutoSize = true;
            MaleButton.Checked = true;
            MaleButton.Location = new Point(437, 48);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(51, 19);
            MaleButton.TabIndex = 5;
            MaleButton.TabStop = true;
            MaleButton.Text = "Male";
            MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            FemaleButton.AutoSize = true;
            FemaleButton.Location = new Point(437, 74);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(63, 19);
            FemaleButton.TabIndex = 6;
            FemaleButton.Text = "Female";
            FemaleButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(668, 74);
            button1.Name = "button1";
            button1.Size = new Size(101, 47);
            button1.TabIndex = 7;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(545, 74);
            button2.Name = "button2";
            button2.Size = new Size(92, 47);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Controls.Add(birthdayDate);
            Controls.Add(surnameInpute);
            Controls.Add(nameInput);
            Controls.Add(dataGridView1);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private DataGridView dataGridView1;
        private TextBox nameInput;
        private TextBox surnameInpute;
        private TextBox birthdayDate;
        private RadioButton MaleButton;
        private RadioButton FemaleButton;
        private Button button1;
        private Button button2;
    }
}
