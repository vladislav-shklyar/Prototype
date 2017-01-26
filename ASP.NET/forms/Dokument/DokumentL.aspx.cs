﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_47130
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ДокументL : BaseListForm<Документ>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ДокументL() : base(Документ.Views.ДокументL)
        {
            EditPage = ДокументE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Dokument/DokumentL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
