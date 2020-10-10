namespace Practica_de_Cotizador___2020_10_09
{
    partial class Cotizador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.MXNORUSD = new System.Windows.Forms.GroupBox();
            this.USDmxn = new System.Windows.Forms.RadioButton();
            this.MXNusd = new System.Windows.Forms.RadioButton();
            this.Input = new System.Windows.Forms.TextBox();
            this.Aqua = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.ImageAxolotl = new System.Windows.Forms.PictureBox();
            this.ImageOutput = new System.Windows.Forms.PictureBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.MXNORUSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAxolotl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCalculadora});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCalculadora
            // 
            this.MenuCalculadora.Name = "MenuCalculadora";
            this.MenuCalculadora.Size = new System.Drawing.Size(82, 20);
            this.MenuCalculadora.Text = "Calculadora";
            this.MenuCalculadora.Click += new System.EventHandler(this.MenuCalculadora_Click);
            // 
            // MXNORUSD
            // 
            this.MXNORUSD.BackColor = System.Drawing.Color.Transparent;
            this.MXNORUSD.Controls.Add(this.USDmxn);
            this.MXNORUSD.Controls.Add(this.MXNusd);
            this.MXNORUSD.Location = new System.Drawing.Point(12, 70);
            this.MXNORUSD.Name = "MXNORUSD";
            this.MXNORUSD.Size = new System.Drawing.Size(317, 98);
            this.MXNORUSD.TabIndex = 4;
            this.MXNORUSD.TabStop = false;
            this.MXNORUSD.Text = "Convertir: ";
            // 
            // USDmxn
            // 
            this.USDmxn.AutoSize = true;
            this.USDmxn.BackColor = System.Drawing.Color.DarkGray;
            this.USDmxn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USDmxn.Location = new System.Drawing.Point(7, 51);
            this.USDmxn.Name = "USDmxn";
            this.USDmxn.Size = new System.Drawing.Size(295, 24);
            this.USDmxn.TabIndex = 1;
            this.USDmxn.TabStop = true;
            this.USDmxn.Text = "Dolares estadounidenes a pesos mexicanos";
            this.USDmxn.UseVisualStyleBackColor = false;
            // 
            // MXNusd
            // 
            this.MXNusd.AutoSize = true;
            this.MXNusd.BackColor = System.Drawing.Color.DarkGray;
            this.MXNusd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MXNusd.Location = new System.Drawing.Point(7, 20);
            this.MXNusd.Name = "MXNusd";
            this.MXNusd.Size = new System.Drawing.Size(302, 24);
            this.MXNusd.TabIndex = 0;
            this.MXNusd.TabStop = true;
            this.MXNusd.Text = "Pesos mexicanos a dolares estadounidenses";
            this.MXNusd.UseVisualStyleBackColor = false;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(157, 32);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(172, 32);
            this.Input.TabIndex = 5;
            // 
            // Aqua
            // 
            this.Aqua.AutoSize = true;
            this.Aqua.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aqua.Location = new System.Drawing.Point(20, 44);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(131, 20);
            this.Aqua.TabIndex = 6;
            this.Aqua.Text = "Cantidad a convertir:";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 174);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 30);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clean
            // 
            this.Clean.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.Location = new System.Drawing.Point(133, 174);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 30);
            this.Clean.TabIndex = 8;
            this.Clean.Text = "Limpiar";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Process
            // 
            this.Process.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.Location = new System.Drawing.Point(254, 174);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 30);
            this.Process.TabIndex = 9;
            this.Process.Text = "Calcular";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // ImageAxolotl
            // 
            this.ImageAxolotl.BackColor = System.Drawing.Color.Transparent;
            this.ImageAxolotl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageAxolotl.BackgroundImage")));
            this.ImageAxolotl.Location = new System.Drawing.Point(389, 143);
            this.ImageAxolotl.Name = "ImageAxolotl";
            this.ImageAxolotl.Size = new System.Drawing.Size(138, 166);
            this.ImageAxolotl.TabIndex = 10;
            this.ImageAxolotl.TabStop = false;
            // 
            // ImageOutput
            // 
            this.ImageOutput.BackColor = System.Drawing.Color.Transparent;
            this.ImageOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageOutput.BackgroundImage")));
            this.ImageOutput.Location = new System.Drawing.Point(454, 44);
            this.ImageOutput.Name = "ImageOutput";
            this.ImageOutput.Size = new System.Drawing.Size(162, 118);
            this.ImageOutput.TabIndex = 11;
            this.ImageOutput.TabStop = false;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(476, 70);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(125, 30);
            this.Output.TabIndex = 12;
            // 
            // Cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 324);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ImageOutput);
            this.Controls.Add(this.ImageAxolotl);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.MXNORUSD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cotizador";
            this.Text = "Cotizador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MXNORUSD.ResumeLayout(false);
            this.MXNORUSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAxolotl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCalculadora;
        private System.Windows.Forms.GroupBox MXNORUSD;
        private System.Windows.Forms.RadioButton USDmxn;
        private System.Windows.Forms.RadioButton MXNusd;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Aqua;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.PictureBox ImageAxolotl;
        private System.Windows.Forms.PictureBox ImageOutput;
        private System.Windows.Forms.TextBox Output;
    }
}

