﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_47130
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ПредставительМИРСL : BaseListForm<ПредставительМИРС>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ПредставительМИРСL() : base(ПредставительМИРС.Views.ПредставительМИРСL)
        {
            EditPage = ПредставительМИРСE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/PredstavitelMIRS/PredstavitelMIRSL.aspx"; }
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