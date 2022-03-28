namespace Zabawki
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfObjects = new System.Windows.Forms.ListBox();
            this.addedObjects = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.depthBox = new System.Windows.Forms.GroupBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.riseBox = new System.Windows.Forms.GroupBox();
            this.riseTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.speedBox.SuspendLayout();
            this.depthBox.SuspendLayout();
            this.riseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfObjects
            // 
            this.listOfObjects.FormattingEnabled = true;
            this.listOfObjects.Location = new System.Drawing.Point(109, 32);
            this.listOfObjects.Name = "listOfObjects";
            this.listOfObjects.Size = new System.Drawing.Size(120, 95);
            this.listOfObjects.TabIndex = 0;
            // 
            // addedObjects
            // 
            this.addedObjects.FormattingEnabled = true;
            this.addedObjects.Location = new System.Drawing.Point(529, 32);
            this.addedObjects.Name = "addedObjects";
            this.addedObjects.Size = new System.Drawing.Size(120, 95);
            this.addedObjects.TabIndex = 1;
            this.addedObjects.SelectedIndexChanged += new System.EventHandler(this.AddedObjects_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddObject);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteObject);
            // 
            // speedBox
            // 
            this.speedBox.Controls.Add(this.speedTextBox);
            this.speedBox.Controls.Add(this.button4);
            this.speedBox.Controls.Add(this.button3);
            this.speedBox.Location = new System.Drawing.Point(109, 182);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(540, 60);
            this.speedBox.TabIndex = 4;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "Speed";
            this.speedBox.Visible = false;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(215, 22);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 2;
            this.speedTextBox.Tag = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.IncreaseSpeed_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DecreaseSpeed_Click);
            // 
            // depthBox
            // 
            this.depthBox.Controls.Add(this.depthTextBox);
            this.depthBox.Controls.Add(this.button5);
            this.depthBox.Controls.Add(this.button6);
            this.depthBox.Location = new System.Drawing.Point(109, 273);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(540, 60);
            this.depthBox.TabIndex = 5;
            this.depthBox.TabStop = false;
            this.depthBox.Text = "Depth";
            this.depthBox.Visible = false;
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(215, 22);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.IncreaseDepth_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DecreaseDepth_Click);
            // 
            // riseBox
            // 
            this.riseBox.Controls.Add(this.riseTextBox);
            this.riseBox.Controls.Add(this.button7);
            this.riseBox.Controls.Add(this.button8);
            this.riseBox.Location = new System.Drawing.Point(109, 365);
            this.riseBox.Name = "riseBox";
            this.riseBox.Size = new System.Drawing.Size(540, 60);
            this.riseBox.TabIndex = 5;
            this.riseBox.TabStop = false;
            this.riseBox.Text = "Rise";
            this.riseBox.Visible = false;
            // 
            // riseTextBox
            // 
            this.riseTextBox.Location = new System.Drawing.Point(215, 21);
            this.riseTextBox.Name = "riseTextBox";
            this.riseTextBox.Size = new System.Drawing.Size(100, 20);
            this.riseTextBox.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(420, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.IncreaseRise_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(45, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.DecreaseRise_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.riseBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addedObjects);
            this.Controls.Add(this.listOfObjects);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.speedBox.ResumeLayout(false);
            this.speedBox.PerformLayout();
            this.depthBox.ResumeLayout(false);
            this.depthBox.PerformLayout();
            this.riseBox.ResumeLayout(false);
            this.riseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfObjects;
        private System.Windows.Forms.ListBox addedObjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox depthBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox riseBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.TextBox riseTextBox;
    }
}

