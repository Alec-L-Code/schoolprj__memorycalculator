using System.Windows.Forms;

namespace Calculator
{
    partial class MemoryCalculatorForm
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
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Subtract_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Divide_Button = new System.Windows.Forms.Button();
            this.Equals_Button = new System.Windows.Forms.Button();
            this.Reciprocal_Button = new System.Windows.Forms.Button();
            this.Sqrt_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Decimal_Button = new System.Windows.Forms.Button();
            this.Number_Three_Button = new System.Windows.Forms.Button();
            this.Number_Six_Button = new System.Windows.Forms.Button();
            this.Number_Nine_Button = new System.Windows.Forms.Button();
            this.Number_Eight_Button = new System.Windows.Forms.Button();
            this.Number_Five_Button = new System.Windows.Forms.Button();
            this.Number_Two_Button = new System.Windows.Forms.Button();
            this.InvertSign_Button = new System.Windows.Forms.Button();
            this.Number_Seven_Button = new System.Windows.Forms.Button();
            this.Number_Four_Button = new System.Windows.Forms.Button();
            this.Number_One_Button = new System.Windows.Forms.Button();
            this.Number_Zero_Button = new System.Windows.Forms.Button();
            this.Memory_TextBox = new System.Windows.Forms.TextBox();
            this.MemoryClear_Button = new System.Windows.Forms.Button();
            this.MemoryRecall_Button = new System.Windows.Forms.Button();
            this.MemoryStore_Button = new System.Windows.Forms.Button();
            this.MemoryAdd_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_TextBox.Location = new System.Drawing.Point(12, 22);
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.ReadOnly = true;
            this.Output_TextBox.Size = new System.Drawing.Size(304, 22);
            this.Output_TextBox.TabIndex = 0;
            this.Output_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.Red;
            this.Add_Button.Location = new System.Drawing.Point(164, 275);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(37, 35);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "+";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Calculator_Addition_Click);
            // 
            // Subtract_Button
            // 
            this.Subtract_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_Button.ForeColor = System.Drawing.Color.Red;
            this.Subtract_Button.Location = new System.Drawing.Point(164, 218);
            this.Subtract_Button.Name = "Subtract_Button";
            this.Subtract_Button.Size = new System.Drawing.Size(37, 35);
            this.Subtract_Button.TabIndex = 4;
            this.Subtract_Button.Text = "--";
            this.Subtract_Button.UseVisualStyleBackColor = true;
            this.Subtract_Button.Click += new System.EventHandler(this.Calculator_Subtraction_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_Button.ForeColor = System.Drawing.Color.Red;
            this.Multiply_Button.Location = new System.Drawing.Point(164, 162);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(37, 35);
            this.Multiply_Button.TabIndex = 5;
            this.Multiply_Button.Text = "*";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            this.Multiply_Button.Click += new System.EventHandler(this.Calculator_Multiply_Click);
            // 
            // Divide_Button
            // 
            this.Divide_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_Button.ForeColor = System.Drawing.Color.Red;
            this.Divide_Button.Location = new System.Drawing.Point(164, 107);
            this.Divide_Button.Name = "Divide_Button";
            this.Divide_Button.Size = new System.Drawing.Size(37, 35);
            this.Divide_Button.TabIndex = 6;
            this.Divide_Button.Text = "/";
            this.Divide_Button.UseVisualStyleBackColor = true;
            this.Divide_Button.Click += new System.EventHandler(this.Calculator_Divide_Click);
            // 
            // Equals_Button
            // 
            this.Equals_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals_Button.ForeColor = System.Drawing.Color.Red;
            this.Equals_Button.Location = new System.Drawing.Point(219, 218);
            this.Equals_Button.Name = "Equals_Button";
            this.Equals_Button.Size = new System.Drawing.Size(37, 92);
            this.Equals_Button.TabIndex = 7;
            this.Equals_Button.Text = "=";
            this.Equals_Button.UseVisualStyleBackColor = true;
            this.Equals_Button.Click += new System.EventHandler(this.Calculator_Equals_Click);
            // 
            // Reciprocal_Button
            // 
            this.Reciprocal_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Reciprocal_Button.Location = new System.Drawing.Point(219, 162);
            this.Reciprocal_Button.Name = "Reciprocal_Button";
            this.Reciprocal_Button.Size = new System.Drawing.Size(37, 35);
            this.Reciprocal_Button.TabIndex = 8;
            this.Reciprocal_Button.Text = "1/x";
            this.Reciprocal_Button.UseVisualStyleBackColor = true;
            this.Reciprocal_Button.Click += new System.EventHandler(this.Calculator_Reciprocal_Click);
            // 
            // Sqrt_Button
            // 
            this.Sqrt_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sqrt_Button.Location = new System.Drawing.Point(219, 107);
            this.Sqrt_Button.Name = "Sqrt_Button";
            this.Sqrt_Button.Size = new System.Drawing.Size(37, 35);
            this.Sqrt_Button.TabIndex = 9;
            this.Sqrt_Button.Text = "sqrt";
            this.Sqrt_Button.UseVisualStyleBackColor = true;
            this.Sqrt_Button.Click += new System.EventHandler(this.Calculator_Sqrt_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.Color.Red;
            this.Clear_Button.Location = new System.Drawing.Point(116, 50);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(125, 35);
            this.Clear_Button.TabIndex = 10;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Calculator_Clear_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.ForeColor = System.Drawing.Color.Red;
            this.Back_Button.Location = new System.Drawing.Point(12, 50);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(80, 35);
            this.Back_Button.TabIndex = 11;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Calculator_Back_Click);
            // 
            // Decimal_Button
            // 
            this.Decimal_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Decimal_Button.Location = new System.Drawing.Point(107, 275);
            this.Decimal_Button.Name = "Decimal_Button";
            this.Decimal_Button.Size = new System.Drawing.Size(37, 35);
            this.Decimal_Button.TabIndex = 12;
            this.Decimal_Button.Text = ".";
            this.Decimal_Button.UseVisualStyleBackColor = true;
            this.Decimal_Button.Click += new System.EventHandler(this.Calculator_Decimal_Click);
            // 
            // Number_Three_Button
            // 
            this.Number_Three_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Three_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Three_Button.Location = new System.Drawing.Point(107, 218);
            this.Number_Three_Button.Name = "Number_Three_Button";
            this.Number_Three_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Three_Button.TabIndex = 13;
            this.Number_Three_Button.Tag = "3";
            this.Number_Three_Button.Text = "3";
            this.Number_Three_Button.UseVisualStyleBackColor = true;
            this.Number_Three_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Six_Button
            // 
            this.Number_Six_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Six_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Six_Button.Location = new System.Drawing.Point(107, 162);
            this.Number_Six_Button.Name = "Number_Six_Button";
            this.Number_Six_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Six_Button.TabIndex = 14;
            this.Number_Six_Button.Tag = "6";
            this.Number_Six_Button.Text = "6";
            this.Number_Six_Button.UseVisualStyleBackColor = true;
            this.Number_Six_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Nine_Button
            // 
            this.Number_Nine_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Nine_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Nine_Button.Location = new System.Drawing.Point(107, 107);
            this.Number_Nine_Button.Name = "Number_Nine_Button";
            this.Number_Nine_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Nine_Button.TabIndex = 15;
            this.Number_Nine_Button.Tag = "9";
            this.Number_Nine_Button.Text = "9";
            this.Number_Nine_Button.UseVisualStyleBackColor = true;
            this.Number_Nine_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Eight_Button
            // 
            this.Number_Eight_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Eight_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Eight_Button.Location = new System.Drawing.Point(55, 107);
            this.Number_Eight_Button.Name = "Number_Eight_Button";
            this.Number_Eight_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Eight_Button.TabIndex = 16;
            this.Number_Eight_Button.Tag = "8";
            this.Number_Eight_Button.Text = "8";
            this.Number_Eight_Button.UseVisualStyleBackColor = true;
            this.Number_Eight_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Five_Button
            // 
            this.Number_Five_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Five_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Five_Button.Location = new System.Drawing.Point(55, 162);
            this.Number_Five_Button.Name = "Number_Five_Button";
            this.Number_Five_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Five_Button.TabIndex = 17;
            this.Number_Five_Button.Tag = "5";
            this.Number_Five_Button.Text = "5";
            this.Number_Five_Button.UseVisualStyleBackColor = true;
            this.Number_Five_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Two_Button
            // 
            this.Number_Two_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Two_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Two_Button.Location = new System.Drawing.Point(55, 218);
            this.Number_Two_Button.Name = "Number_Two_Button";
            this.Number_Two_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Two_Button.TabIndex = 18;
            this.Number_Two_Button.Tag = "2";
            this.Number_Two_Button.Text = "2";
            this.Number_Two_Button.UseVisualStyleBackColor = true;
            this.Number_Two_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // InvertSign_Button
            // 
            this.InvertSign_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvertSign_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InvertSign_Button.Location = new System.Drawing.Point(55, 275);
            this.InvertSign_Button.Name = "InvertSign_Button";
            this.InvertSign_Button.Size = new System.Drawing.Size(37, 35);
            this.InvertSign_Button.TabIndex = 19;
            this.InvertSign_Button.Text = "+/-";
            this.InvertSign_Button.UseVisualStyleBackColor = true;
            this.InvertSign_Button.Click += new System.EventHandler(this.Calculator_Invert_Click);
            // 
            // Number_Seven_Button
            // 
            this.Number_Seven_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Seven_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Seven_Button.Location = new System.Drawing.Point(3, 107);
            this.Number_Seven_Button.Name = "Number_Seven_Button";
            this.Number_Seven_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Seven_Button.TabIndex = 20;
            this.Number_Seven_Button.Tag = "7";
            this.Number_Seven_Button.Text = "7";
            this.Number_Seven_Button.UseVisualStyleBackColor = true;
            this.Number_Seven_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Four_Button
            // 
            this.Number_Four_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Four_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Four_Button.Location = new System.Drawing.Point(3, 162);
            this.Number_Four_Button.Name = "Number_Four_Button";
            this.Number_Four_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Four_Button.TabIndex = 21;
            this.Number_Four_Button.Tag = "4";
            this.Number_Four_Button.Text = "4";
            this.Number_Four_Button.UseVisualStyleBackColor = true;
            this.Number_Four_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_One_Button
            // 
            this.Number_One_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_One_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_One_Button.Location = new System.Drawing.Point(3, 218);
            this.Number_One_Button.Name = "Number_One_Button";
            this.Number_One_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_One_Button.TabIndex = 22;
            this.Number_One_Button.Tag = "1";
            this.Number_One_Button.Text = "1";
            this.Number_One_Button.UseVisualStyleBackColor = true;
            this.Number_One_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Number_Zero_Button
            // 
            this.Number_Zero_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Zero_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_Zero_Button.Location = new System.Drawing.Point(3, 275);
            this.Number_Zero_Button.Name = "Number_Zero_Button";
            this.Number_Zero_Button.Size = new System.Drawing.Size(37, 35);
            this.Number_Zero_Button.TabIndex = 23;
            this.Number_Zero_Button.Tag = "0";
            this.Number_Zero_Button.Text = "0";
            this.Number_Zero_Button.UseVisualStyleBackColor = true;
            this.Number_Zero_Button.Click += new System.EventHandler(this.Calculator_Number_Click);
            // 
            // Memory_TextBox
            // 
            this.Memory_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory_TextBox.Location = new System.Drawing.Point(274, 58);
            this.Memory_TextBox.Multiline = true;
            this.Memory_TextBox.Name = "Memory_TextBox";
            this.Memory_TextBox.ReadOnly = true;
            this.Memory_TextBox.Size = new System.Drawing.Size(42, 43);
            this.Memory_TextBox.TabIndex = 24;
            this.Memory_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MemoryClear_Button
            // 
            this.MemoryClear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryClear_Button.ForeColor = System.Drawing.Color.Red;
            this.MemoryClear_Button.Location = new System.Drawing.Point(274, 107);
            this.MemoryClear_Button.Name = "MemoryClear_Button";
            this.MemoryClear_Button.Size = new System.Drawing.Size(42, 35);
            this.MemoryClear_Button.TabIndex = 25;
            this.MemoryClear_Button.Text = "MC";
            this.MemoryClear_Button.UseVisualStyleBackColor = true;
            this.MemoryClear_Button.Click += new System.EventHandler(this.MemoryClear_Button_Click);
            // 
            // MemoryRecall_Button
            // 
            this.MemoryRecall_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryRecall_Button.ForeColor = System.Drawing.Color.Red;
            this.MemoryRecall_Button.Location = new System.Drawing.Point(274, 162);
            this.MemoryRecall_Button.Name = "MemoryRecall_Button";
            this.MemoryRecall_Button.Size = new System.Drawing.Size(42, 35);
            this.MemoryRecall_Button.TabIndex = 26;
            this.MemoryRecall_Button.Text = "MR";
            this.MemoryRecall_Button.UseVisualStyleBackColor = true;
            this.MemoryRecall_Button.Click += new System.EventHandler(this.MemoryRecall_Button_Click);
            // 
            // MemoryStore_Button
            // 
            this.MemoryStore_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryStore_Button.ForeColor = System.Drawing.Color.Red;
            this.MemoryStore_Button.Location = new System.Drawing.Point(274, 218);
            this.MemoryStore_Button.Name = "MemoryStore_Button";
            this.MemoryStore_Button.Size = new System.Drawing.Size(42, 35);
            this.MemoryStore_Button.TabIndex = 27;
            this.MemoryStore_Button.Text = "MS";
            this.MemoryStore_Button.UseVisualStyleBackColor = true;
            this.MemoryStore_Button.Click += new System.EventHandler(this.MemoryStore_Button_Click);
            // 
            // MemoryAdd_Button
            // 
            this.MemoryAdd_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryAdd_Button.ForeColor = System.Drawing.Color.Red;
            this.MemoryAdd_Button.Location = new System.Drawing.Point(274, 275);
            this.MemoryAdd_Button.Name = "MemoryAdd_Button";
            this.MemoryAdd_Button.Size = new System.Drawing.Size(42, 35);
            this.MemoryAdd_Button.TabIndex = 28;
            this.MemoryAdd_Button.Text = "M+";
            this.MemoryAdd_Button.UseVisualStyleBackColor = true;
            this.MemoryAdd_Button.Click += new System.EventHandler(this.MemoryAdd_Button_Click);
            // 
            // MemoryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 316);
            this.Controls.Add(this.MemoryAdd_Button);
            this.Controls.Add(this.MemoryStore_Button);
            this.Controls.Add(this.MemoryRecall_Button);
            this.Controls.Add(this.MemoryClear_Button);
            this.Controls.Add(this.Memory_TextBox);
            this.Controls.Add(this.Number_Zero_Button);
            this.Controls.Add(this.Number_One_Button);
            this.Controls.Add(this.Number_Four_Button);
            this.Controls.Add(this.Number_Seven_Button);
            this.Controls.Add(this.InvertSign_Button);
            this.Controls.Add(this.Number_Two_Button);
            this.Controls.Add(this.Number_Five_Button);
            this.Controls.Add(this.Number_Eight_Button);
            this.Controls.Add(this.Number_Nine_Button);
            this.Controls.Add(this.Number_Six_Button);
            this.Controls.Add(this.Number_Three_Button);
            this.Controls.Add(this.Decimal_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Sqrt_Button);
            this.Controls.Add(this.Reciprocal_Button);
            this.Controls.Add(this.Equals_Button);
            this.Controls.Add(this.Divide_Button);
            this.Controls.Add(this.Multiply_Button);
            this.Controls.Add(this.Subtract_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Output_TextBox);
            this.Name = "MemoryCalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Output_TextBox;
        private Button Add_Button;
        private Button Subtract_Button;
        private Button Multiply_Button;
        private Button Divide_Button;
        private Button Equals_Button;
        private Button Reciprocal_Button;
        private Button Sqrt_Button;
        private Button Clear_Button;
        private Button Back_Button;
        private Button Decimal_Button;
        private Button Number_Three_Button;
        private Button Number_Six_Button;
        private Button Number_Nine_Button;
        private Button Number_Eight_Button;
        private Button Number_Five_Button;
        private Button Number_Two_Button;
        private Button InvertSign_Button;
        private Button Number_Seven_Button;
        private Button Number_Four_Button;
        private Button Number_One_Button;
        private Button Number_Zero_Button;
        private TextBox Memory_TextBox;
        private Button MemoryClear_Button;
        private Button MemoryRecall_Button;
        private Button MemoryStore_Button;
        private Button MemoryAdd_Button;
    }
}

