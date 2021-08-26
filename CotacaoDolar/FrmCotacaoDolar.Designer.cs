
namespace CotacaoDolar
{
    partial class FrmCotacaoDolar
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
            this.lblDolar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblVariation = new System.Windows.Forms.Label();
            this.lblGetBuy = new System.Windows.Forms.Label();
            this.lblGetSale = new System.Windows.Forms.Label();
            this.lblVariationfrequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolar
            // 
            this.lblDolar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDolar.Location = new System.Drawing.Point(2, 9);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(815, 102);
            this.lblDolar.TabIndex = 0;
            this.lblDolar.Text = "Dólar";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buy";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(624, 375);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSale.Location = new System.Drawing.Point(52, 212);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(77, 32);
            this.lblSale.TabIndex = 3;
            this.lblSale.Text = "Sale";
            // 
            // lblVariation
            // 
            this.lblVariation.AutoSize = true;
            this.lblVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVariation.Location = new System.Drawing.Point(52, 279);
            this.lblVariation.Name = "lblVariation";
            this.lblVariation.Size = new System.Drawing.Size(138, 32);
            this.lblVariation.TabIndex = 4;
            this.lblVariation.Text = "Variation";
            // 
            // lblGetBuy
            // 
            this.lblGetBuy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblGetBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGetBuy.Location = new System.Drawing.Point(252, 136);
            this.lblGetBuy.Name = "lblGetBuy";
            this.lblGetBuy.Size = new System.Drawing.Size(353, 36);
            this.lblGetBuy.TabIndex = 5;
            this.lblGetBuy.Text = "0,0";
            this.lblGetBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGetSale
            // 
            this.lblGetSale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGetSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetSale.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblGetSale.Location = new System.Drawing.Point(252, 212);
            this.lblGetSale.Name = "lblGetSale";
            this.lblGetSale.Size = new System.Drawing.Size(353, 36);
            this.lblGetSale.TabIndex = 6;
            this.lblGetSale.Text = "0,0";
            this.lblGetSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVariationfrequency
            // 
            this.lblVariationfrequency.BackColor = System.Drawing.Color.Aqua;
            this.lblVariationfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariationfrequency.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVariationfrequency.Location = new System.Drawing.Point(252, 279);
            this.lblVariationfrequency.Name = "lblVariationfrequency";
            this.lblVariationfrequency.Size = new System.Drawing.Size(353, 36);
            this.lblVariationfrequency.TabIndex = 7;
            this.lblVariationfrequency.Text = "0,0";
            this.lblVariationfrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 448);
            this.Controls.Add(this.lblVariationfrequency);
            this.Controls.Add(this.lblGetSale);
            this.Controls.Add(this.lblGetBuy);
            this.Controls.Add(this.lblVariation);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CotacaoDolar";
            this.Load += new System.EventHandler(this.FrmCotacaoDolar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblVariation;
        private System.Windows.Forms.Label lblGetBuy;
        private System.Windows.Forms.Label lblGetSale;
        private System.Windows.Forms.Label lblVariationfrequency;
    }
}

