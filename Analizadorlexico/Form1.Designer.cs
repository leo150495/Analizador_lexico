namespace Analizadorlexico
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grb_resultado = new System.Windows.Forms.GroupBox();
            this.dgt_resultado = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_control = new System.Windows.Forms.GroupBox();
            this.btn_analizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.grb_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_resultado)).BeginInit();
            this.grb_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese el texto";
            // 
            // grb_resultado
            // 
            this.grb_resultado.Controls.Add(this.dgt_resultado);
            this.grb_resultado.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_resultado.Location = new System.Drawing.Point(402, 28);
            this.grb_resultado.Margin = new System.Windows.Forms.Padding(4);
            this.grb_resultado.Name = "grb_resultado";
            this.grb_resultado.Padding = new System.Windows.Forms.Padding(4);
            this.grb_resultado.Size = new System.Drawing.Size(405, 376);
            this.grb_resultado.TabIndex = 6;
            this.grb_resultado.TabStop = false;
            this.grb_resultado.Text = "Resultado";
            // 
            // dgt_resultado
            // 
            this.dgt_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num,
            this.col_lex,
            this.col_token});
            this.dgt_resultado.Location = new System.Drawing.Point(30, 24);
            this.dgt_resultado.Margin = new System.Windows.Forms.Padding(4);
            this.dgt_resultado.Name = "dgt_resultado";
            this.dgt_resultado.Size = new System.Drawing.Size(355, 344);
            this.dgt_resultado.TabIndex = 0;
            // 
            // col_num
            // 
            this.col_num.Frozen = true;
            this.col_num.HeaderText = "#";
            this.col_num.Name = "col_num";
            this.col_num.ReadOnly = true;
            this.col_num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_num.Width = 30;
            // 
            // col_lex
            // 
            this.col_lex.Frozen = true;
            this.col_lex.HeaderText = "Lexema";
            this.col_lex.Name = "col_lex";
            this.col_lex.ReadOnly = true;
            this.col_lex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_token
            // 
            this.col_token.Frozen = true;
            this.col_token.HeaderText = "Token";
            this.col_token.Name = "col_token";
            this.col_token.ReadOnly = true;
            this.col_token.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_token.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grb_control
            // 
            this.grb_control.Controls.Add(this.btn_analizar);
            this.grb_control.Controls.Add(this.btn_nuevo);
            this.grb_control.Font = new System.Drawing.Font("Montserrat", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_control.Location = new System.Drawing.Point(28, 430);
            this.grb_control.Margin = new System.Windows.Forms.Padding(4);
            this.grb_control.Name = "grb_control";
            this.grb_control.Padding = new System.Windows.Forms.Padding(4);
            this.grb_control.Size = new System.Drawing.Size(446, 80);
            this.grb_control.TabIndex = 5;
            this.grb_control.TabStop = false;
            this.grb_control.Text = "Controles";
            // 
            // btn_analizar
            // 
            this.btn_analizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analizar.Location = new System.Drawing.Point(267, 23);
            this.btn_analizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_analizar.Name = "btn_analizar";
            this.btn_analizar.Size = new System.Drawing.Size(162, 41);
            this.btn_analizar.TabIndex = 0;
            this.btn_analizar.Text = "Analizar";
            this.btn_analizar.UseVisualStyleBackColor = true;
            this.btn_analizar.Click += new System.EventHandler(this.btn_analizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(34, 23);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(174, 41);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(28, 50);
            this.txt_texto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_texto.Multiline = true;
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(342, 354);
            this.txt_texto.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(845, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_resultado);
            this.Controls.Add(this.grb_control);
            this.Controls.Add(this.txt_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_resultado)).EndInit();
            this.grb_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_resultado;
        private System.Windows.Forms.DataGridView dgt_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_token;
        private System.Windows.Forms.GroupBox grb_control;
        private System.Windows.Forms.Button btn_analizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox txt_texto;
    }
}

