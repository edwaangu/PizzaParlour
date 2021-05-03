
namespace PizzaParlour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleText = new System.Windows.Forms.Label();
            this.toppingText = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inputToppingsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.Peru;
            this.titleText.Font = new System.Drawing.Font("Becker Gothics Egyptian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(684, 83);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Pizza Parlour";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toppingText
            // 
            this.toppingText.Font = new System.Drawing.Font("Arial", 12F);
            this.toppingText.Location = new System.Drawing.Point(205, 143);
            this.toppingText.Name = "toppingText";
            this.toppingText.Size = new System.Drawing.Size(151, 23);
            this.toppingText.TabIndex = 1;
            this.toppingText.Text = "Amount of Toppings:";
            this.toppingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.Font = new System.Drawing.Font("Arial", 14F);
            this.outputText.Location = new System.Drawing.Point(95, 310);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(500, 125);
            this.outputText.TabIndex = 2;
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 12F);
            this.calculateButton.Location = new System.Drawing.Point(262, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 63);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // inputToppingsBox
            // 
            this.inputToppingsBox.Location = new System.Drawing.Point(353, 144);
            this.inputToppingsBox.Name = "inputToppingsBox";
            this.inputToppingsBox.Size = new System.Drawing.Size(100, 20);
            this.inputToppingsBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.inputToppingsBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.toppingText);
            this.Controls.Add(this.titleText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Topping Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label toppingText;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox inputToppingsBox;
    }
}

