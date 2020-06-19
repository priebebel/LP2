namespace Atividade7
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLerNumeros = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMercadorias = new System.Windows.Forms.Button();
            this.btnVarTotal = new System.Windows.Forms.Button();
            this.btnUsoArray = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnExe7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLerNumeros
            // 
            this.btnLerNumeros.Location = new System.Drawing.Point(43, 55);
            this.btnLerNumeros.Name = "btnLerNumeros";
            this.btnLerNumeros.Size = new System.Drawing.Size(115, 57);
            this.btnLerNumeros.TabIndex = 0;
            this.btnLerNumeros.Text = "Mostra 20 num";
            this.btnLerNumeros.UseVisualStyleBackColor = true;
            this.btnLerNumeros.Click += new System.EventHandler(this.btnLerNumeros_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(188, 55);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(115, 57);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Mostra 20 num Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnMercadorias
            // 
            this.btnMercadorias.Location = new System.Drawing.Point(331, 55);
            this.btnMercadorias.Name = "btnMercadorias";
            this.btnMercadorias.Size = new System.Drawing.Size(115, 57);
            this.btnMercadorias.TabIndex = 2;
            this.btnMercadorias.Text = "Mercadorias";
            this.btnMercadorias.UseVisualStyleBackColor = true;
            this.btnMercadorias.Click += new System.EventHandler(this.btnMercadorias_Click);
            // 
            // btnVarTotal
            // 
            this.btnVarTotal.Location = new System.Drawing.Point(43, 125);
            this.btnVarTotal.Name = "btnVarTotal";
            this.btnVarTotal.Size = new System.Drawing.Size(115, 57);
            this.btnVarTotal.TabIndex = 3;
            this.btnVarTotal.Text = "Variavel total";
            this.btnVarTotal.UseVisualStyleBackColor = true;
            this.btnVarTotal.Click += new System.EventHandler(this.btnVarTotal_Click);
            // 
            // btnUsoArray
            // 
            this.btnUsoArray.Location = new System.Drawing.Point(188, 125);
            this.btnUsoArray.Name = "btnUsoArray";
            this.btnUsoArray.Size = new System.Drawing.Size(115, 57);
            this.btnUsoArray.TabIndex = 4;
            this.btnUsoArray.Text = "ArrayList";
            this.btnUsoArray.UseVisualStyleBackColor = true;
            this.btnUsoArray.Click += new System.EventHandler(this.btnUsoArray_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(331, 125);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(115, 57);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "Media 20 alunos em 3 disciplinas";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnExe7
            // 
            this.btnExe7.Location = new System.Drawing.Point(43, 198);
            this.btnExe7.Name = "btnExe7";
            this.btnExe7.Size = new System.Drawing.Size(115, 57);
            this.btnExe7.TabIndex = 6;
            this.btnExe7.Text = "Exercicio 7";
            this.btnExe7.UseVisualStyleBackColor = true;
            this.btnExe7.Click += new System.EventHandler(this.btnExe7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 306);
            this.Controls.Add(this.btnExe7);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnUsoArray);
            this.Controls.Add(this.btnVarTotal);
            this.Controls.Add(this.btnMercadorias);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnLerNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLerNumeros;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMercadorias;
        private System.Windows.Forms.Button btnVarTotal;
        private System.Windows.Forms.Button btnUsoArray;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnNumPessoas;
        private System.Windows.Forms.Button btnExe7;
    }
}

