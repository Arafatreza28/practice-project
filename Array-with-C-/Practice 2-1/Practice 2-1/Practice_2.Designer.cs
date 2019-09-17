namespace Practice_2_1
{
    partial class Practice_2
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
            this.sizeLabel = new System.Windows.Forms.Label();
            this.elementLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.addsizeButton = new System.Windows.Forms.Button();
            this.addelementButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(162, 53);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Size";
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(165, 88);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(45, 13);
            this.elementLabel.TabIndex = 1;
            this.elementLabel.Text = "Element";
            this.elementLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(250, 45);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 2;
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(250, 88);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(100, 20);
            this.elementTextBox.TabIndex = 3;
            // 
            // addsizeButton
            // 
            this.addsizeButton.Location = new System.Drawing.Point(396, 41);
            this.addsizeButton.Name = "addsizeButton";
            this.addsizeButton.Size = new System.Drawing.Size(75, 23);
            this.addsizeButton.TabIndex = 4;
            this.addsizeButton.Text = "Add Size";
            this.addsizeButton.UseVisualStyleBackColor = true;
            this.addsizeButton.Click += new System.EventHandler(this.addsizeButton_Click);
            // 
            // addelementButton
            // 
            this.addelementButton.Location = new System.Drawing.Point(396, 85);
            this.addelementButton.Name = "addelementButton";
            this.addelementButton.Size = new System.Drawing.Size(75, 23);
            this.addelementButton.TabIndex = 5;
            this.addelementButton.Text = "Add Element";
            this.addelementButton.UseVisualStyleBackColor = true;
            this.addelementButton.Click += new System.EventHandler(this.addelementButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(396, 145);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Practice_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.addelementButton);
            this.Controls.Add(this.addsizeButton);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.sizeLabel);
            this.Name = "Practice_2";
            this.Text = "Practice_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Button addsizeButton;
        private System.Windows.Forms.Button addelementButton;
        private System.Windows.Forms.Button showButton;
    }
}

