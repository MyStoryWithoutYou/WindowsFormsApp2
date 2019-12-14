namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.onOffBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.y_change = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.changeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeChange = new System.Windows.Forms.Button();
            this.locationChange = new System.Windows.Forms.Button();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.x_change = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // onOffBtn
            // 
            this.onOffBtn.Location = new System.Drawing.Point(22, 90);
            this.onOffBtn.Name = "onOffBtn";
            this.onOffBtn.Size = new System.Drawing.Size(127, 23);
            this.onOffBtn.TabIndex = 0;
            this.onOffBtn.Text = "Включить/выключить";
            this.onOffBtn.UseVisualStyleBackColor = true;
            this.onOffBtn.Click += new System.EventHandler(this.onOffBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(193, 122);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Надпись";
            // 
            // y_change
            // 
            this.y_change.Location = new System.Drawing.Point(576, 116);
            this.y_change.Name = "y_change";
            this.y_change.Size = new System.Drawing.Size(100, 20);
            this.y_change.TabIndex = 3;
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(393, 42);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(100, 20);
            this.lengthTxt.TabIndex = 4;
            // 
            // changeTxt
            // 
            this.changeTxt.Location = new System.Drawing.Point(182, 63);
            this.changeTxt.Name = "changeTxt";
            this.changeTxt.Size = new System.Drawing.Size(100, 20);
            this.changeTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ширина";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sizeChange
            // 
            this.sizeChange.Location = new System.Drawing.Point(405, 169);
            this.sizeChange.Name = "sizeChange";
            this.sizeChange.Size = new System.Drawing.Size(75, 23);
            this.sizeChange.TabIndex = 8;
            this.sizeChange.Text = "Изменить";
            this.sizeChange.UseVisualStyleBackColor = true;
            this.sizeChange.Click += new System.EventHandler(this.sizeChange_Click);
            // 
            // locationChange
            // 
            this.locationChange.Location = new System.Drawing.Point(587, 169);
            this.locationChange.Name = "locationChange";
            this.locationChange.Size = new System.Drawing.Size(75, 23);
            this.locationChange.TabIndex = 9;
            this.locationChange.Text = "Изменить";
            this.locationChange.UseVisualStyleBackColor = true;
            this.locationChange.Click += new System.EventHandler(this.locationChange_Click);
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(393, 116);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(100, 20);
            this.widthTxt.TabIndex = 10;
            // 
            // x_change
            // 
            this.x_change.Location = new System.Drawing.Point(576, 42);
            this.x_change.Name = "x_change";
            this.x_change.Size = new System.Drawing.Size(100, 20);
            this.x_change.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Координата Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Координата Х";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(348, 291);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(49, 13);
            this.linkLabel.TabIndex = 14;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "linkLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x_change);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.locationChange);
            this.Controls.Add(this.sizeChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.y_change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.onOffBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onOffBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox y_change;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox changeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sizeChange;
        private System.Windows.Forms.Button locationChange;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox x_change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}

