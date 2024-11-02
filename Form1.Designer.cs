private void InitializeComponent()
{
    this.textBoxNum1 = new System.Windows.Forms.TextBox();
    this.textBoxNum2 = new System.Windows.Forms.TextBox();
    this.buttonSumar = new System.Windows.Forms.Button();
    this.buttonRestar = new System.Windows.Forms.Button();
    this.buttonLimpiar = new System.Windows.Forms.Button();
    this.listBoxResultados = new System.Windows.Forms.ListBox();
    this.SuspendLayout();
    // 
    // textBoxNum1
    // 
    this.textBoxNum1.Location = new System.Drawing.Point(12, 12);
    this.textBoxNum1.Name = "textBoxNum1";
    this.textBoxNum1.Size = new System.Drawing.Size(100, 22);
    this.textBoxNum1.TabIndex = 0;
    // 
    // textBoxNum2
    // 
    this.textBoxNum2.Location = new System.Drawing.Point(118, 12);
    this.textBoxNum2.Name = "textBoxNum2";
    this.textBoxNum2.Size = new System.Drawing.Size(100, 22);
    this.textBoxNum2.TabIndex = 1;
    // 
    // buttonSumar
    // 
    this.buttonSumar.Location = new System.Drawing.Point(224, 12);
    this.buttonSumar.Name = "buttonSumar";
    this.buttonSumar.Size = new System.Drawing.Size(75, 23);
    this.buttonSumar.TabIndex = 2;
    this.buttonSumar.Text = "Sumar";
    this.buttonSumar.UseVisualStyleBackColor = true;
    this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
    // 
    // buttonRestar
    // 
    this.buttonRestar.Location = new System.Drawing.Point(305, 12);
    this.buttonRestar.Name = "buttonRestar";
    this.buttonRestar.Size = new System.Drawing.Size(75, 23);
    this.buttonRestar.TabIndex = 3;
    this.buttonRestar.Text = "Restar";
    this.buttonRestar.UseVisualStyleBackColor = true;
    this.buttonRestar.Click += new System.EventHandler(this.buttonRestar_Click);
    // 
    // buttonLimpiar
    // 
    this.buttonLimpiar.Location = new System.Drawing.Point(386, 12);
    this.buttonLimpiar.Name = "buttonLimpiar";
    this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
    this.buttonLimpiar.TabIndex = 4;
    this.buttonLimpiar.Text = "Limpiar";
    this.buttonLimpiar.UseVisualStyleBackColor = true;
    this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
    // 
    // listBoxResultados
    // 
    this.listBoxResultados.FormattingEnabled = true;
    this.listBoxResultados.ItemHeight = 16;
    this.listBoxResultados.Location = new System.Drawing.Point(12, 41);
    this.listBoxResultados.Name = "listBoxResultados";
    this.listBoxResultados.Size = new System.Drawing.Size(449, 196);
    this.listBoxResultados.TabIndex = 5;
    // 
    // Form1
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(473, 253);
    this.Controls.Add(this.listBoxResultados);
    this.Controls.Add(this.buttonLimpiar);
    this.Controls.Add(this.buttonRestar);
    this.Controls.Add(this.buttonSumar);
    this.Controls.Add(this.textBoxNum2);
    this.Controls.Add(this.textBoxNum1);
    this.Name = "Form1";
    this.Text = "Calculadora";
    this.ResumeLayout(false);
    this.PerformLayout();
}

private System.Windows.Forms.TextBox textBoxNum1;
private System.Windows.Forms.TextBox textBoxNum2;
private System.Windows.Forms.Button buttonSumar;
private System.Windows.Forms.Button buttonRestar;
private System.Windows.Forms.Button buttonLimpiar;
private System.Windows.Forms.ListBox listBoxResultados;
