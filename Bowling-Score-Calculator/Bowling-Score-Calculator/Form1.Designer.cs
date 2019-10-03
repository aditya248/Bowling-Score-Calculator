namespace Bowling_Score_Calculator
{
    partial class Form1
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(588, 159);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 25);
            this.scoreLabel.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Score:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(505, 191);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(138, 39);
            this.resetButton.TabIndex = 27;
            this.resetButton.Text = "Reset Game";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bowling Score Calculator";
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(146, 88);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(67, 40);
            this.button0.TabIndex = 25;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += number_Click;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(900, 88);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 40);
            this.button10.TabIndex = 24;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += number_Click;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(827, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 40);
            this.button9.TabIndex = 23;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += number_Click;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(754, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 40);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += number_Click;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(681, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 40);
            this.button7.TabIndex = 21;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += number_Click;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(608, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 40);
            this.button6.TabIndex = 20;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += number_Click;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(535, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 40);
            this.button5.TabIndex = 19;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += number_Click;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += number_Click;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 40);
            this.button4.TabIndex = 17;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += number_Click;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += number_Click;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += number_Click;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(377, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 397);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.Red;
            this.endLabel.Location = new System.Drawing.Point(502, 246);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 25);
            this.endLabel.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 684);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label endLabel;
    }
}

