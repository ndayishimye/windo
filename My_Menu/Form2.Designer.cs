namespace Menu
{
    partial class Form2
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
            this.label1_for_calculator = new System.Windows.Forms.Label();
            this.label2_for_firstnumber = new System.Windows.Forms.Label();
            this.label3_for_secondnumber = new System.Windows.Forms.Label();
            this.textBox1_for_firstnumber = new System.Windows.Forms.TextBox();
            this.textBox2_for_secondnumber = new System.Windows.Forms.TextBox();
            this.groupBox1_operation = new System.Windows.Forms.GroupBox();
            this.button4_division = new System.Windows.Forms.Button();
            this.button3_multiplication = new System.Windows.Forms.Button();
            this.button2_subtraction = new System.Windows.Forms.Button();
            this.button1_addition = new System.Windows.Forms.Button();
            this.label4_result = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.groupBox1_operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_for_calculator
            // 
            this.label1_for_calculator.AutoSize = true;
            this.label1_for_calculator.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_for_calculator.Location = new System.Drawing.Point(203, 21);
            this.label1_for_calculator.Name = "label1_for_calculator";
            this.label1_for_calculator.Size = new System.Drawing.Size(151, 20);
            this.label1_for_calculator.TabIndex = 0;
            this.label1_for_calculator.Text = "SIMPLE CALCULATOR";
            this.label1_for_calculator.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2_for_firstnumber
            // 
            this.label2_for_firstnumber.AutoSize = true;
            this.label2_for_firstnumber.BackColor = System.Drawing.Color.MintCream;
            this.label2_for_firstnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_for_firstnumber.Location = new System.Drawing.Point(221, 62);
            this.label2_for_firstnumber.Name = "label2_for_firstnumber";
            this.label2_for_firstnumber.Size = new System.Drawing.Size(110, 20);
            this.label2_for_firstnumber.TabIndex = 1;
            this.label2_for_firstnumber.Text = "First number";
            this.label2_for_firstnumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3_for_secondnumber
            // 
            this.label3_for_secondnumber.AutoSize = true;
            this.label3_for_secondnumber.BackColor = System.Drawing.Color.MintCream;
            this.label3_for_secondnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_for_secondnumber.Location = new System.Drawing.Point(204, 128);
            this.label3_for_secondnumber.Name = "label3_for_secondnumber";
            this.label3_for_secondnumber.Size = new System.Drawing.Size(137, 20);
            this.label3_for_secondnumber.TabIndex = 2;
            this.label3_for_secondnumber.Text = "Second Number";
            this.label3_for_secondnumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1_for_firstnumber
            // 
            this.textBox1_for_firstnumber.Location = new System.Drawing.Point(190, 95);
            this.textBox1_for_firstnumber.Name = "textBox1_for_firstnumber";
            this.textBox1_for_firstnumber.Size = new System.Drawing.Size(166, 20);
            this.textBox1_for_firstnumber.TabIndex = 3;
            this.textBox1_for_firstnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_for_secondnumber
            // 
            this.textBox2_for_secondnumber.Location = new System.Drawing.Point(190, 167);
            this.textBox2_for_secondnumber.Name = "textBox2_for_secondnumber";
            this.textBox2_for_secondnumber.Size = new System.Drawing.Size(166, 20);
            this.textBox2_for_secondnumber.TabIndex = 4;
            this.textBox2_for_secondnumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1_operation
            // 
            this.groupBox1_operation.Controls.Add(this.button4_division);
            this.groupBox1_operation.Controls.Add(this.button3_multiplication);
            this.groupBox1_operation.Controls.Add(this.button2_subtraction);
            this.groupBox1_operation.Controls.Add(this.button1_addition);
            this.groupBox1_operation.Location = new System.Drawing.Point(177, 201);
            this.groupBox1_operation.Name = "groupBox1_operation";
            this.groupBox1_operation.Size = new System.Drawing.Size(178, 127);
            this.groupBox1_operation.TabIndex = 5;
            this.groupBox1_operation.TabStop = false;
            this.groupBox1_operation.Text = "Operators";
            this.groupBox1_operation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4_division
            // 
            this.button4_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_division.Location = new System.Drawing.Point(80, 80);
            this.button4_division.Name = "button4_division";
            this.button4_division.Size = new System.Drawing.Size(37, 32);
            this.button4_division.TabIndex = 3;
            this.button4_division.Text = "/";
            this.button4_division.UseVisualStyleBackColor = false;
            this.button4_division.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3_multiplication
            // 
            this.button3_multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_multiplication.Location = new System.Drawing.Point(20, 80);
            this.button3_multiplication.Name = "button3_multiplication";
            this.button3_multiplication.Size = new System.Drawing.Size(37, 32);
            this.button3_multiplication.TabIndex = 2;
            this.button3_multiplication.Text = "*";
            this.button3_multiplication.UseVisualStyleBackColor = false;
            this.button3_multiplication.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2_subtraction
            // 
            this.button2_subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_subtraction.Location = new System.Drawing.Point(80, 33);
            this.button2_subtraction.Name = "button2_subtraction";
            this.button2_subtraction.Size = new System.Drawing.Size(37, 32);
            this.button2_subtraction.TabIndex = 1;
            this.button2_subtraction.Text = "-";
            this.button2_subtraction.UseVisualStyleBackColor = false;
            this.button2_subtraction.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1_addition
            // 
            this.button1_addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_addition.Location = new System.Drawing.Point(20, 33);
            this.button1_addition.Name = "button1_addition";
            this.button1_addition.Size = new System.Drawing.Size(37, 32);
            this.button1_addition.TabIndex = 0;
            this.button1_addition.Text = "+";
            this.button1_addition.UseVisualStyleBackColor = false;
            this.button1_addition.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4_result
            // 
            this.label4_result.AutoSize = true;
            this.label4_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_result.Location = new System.Drawing.Point(204, 365);
            this.label4_result.Name = "label4_result";
            this.label4_result.Size = new System.Drawing.Size(61, 20);
            this.label4_result.TabIndex = 6;
            this.label4_result.Text = "Result";
            this.label4_result.Click += new System.EventHandler(this.label4_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(271, 365);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(70, 20);
            this.result.TabIndex = 7;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4_result);
            this.Controls.Add(this.groupBox1_operation);
            this.Controls.Add(this.textBox2_for_secondnumber);
            this.Controls.Add(this.textBox1_for_firstnumber);
            this.Controls.Add(this.label3_for_secondnumber);
            this.Controls.Add(this.label2_for_firstnumber);
            this.Controls.Add(this.label1_for_calculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1_operation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_for_calculator;
        private System.Windows.Forms.Label label2_for_firstnumber;
        private System.Windows.Forms.Label label3_for_secondnumber;
        private System.Windows.Forms.TextBox textBox1_for_firstnumber;
        private System.Windows.Forms.TextBox textBox2_for_secondnumber;
        private System.Windows.Forms.GroupBox groupBox1_operation;
        private System.Windows.Forms.Button button4_division;
        private System.Windows.Forms.Button button3_multiplication;
        private System.Windows.Forms.Button button2_subtraction;
        private System.Windows.Forms.Button button1_addition;
        private System.Windows.Forms.Label label4_result;
        private System.Windows.Forms.TextBox result;
    }
}