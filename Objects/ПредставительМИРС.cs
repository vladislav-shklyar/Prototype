﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_47130
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Представитель МИРС.
    /// </summary>
    // *** Start programmer edit section *** (ПредставительМИРС CustomAttributes)

    // *** End programmer edit section *** (ПредставительМИРС CustomAttributes)
    [AutoAltered()]
    [Caption("Представитель МИРС")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПредставительМИРСE", new string[] {
            "Имя as \'Имя\'",
            "Почта as \'Почта\'",
            "Телефон as \'Телефон\'",
            "Должность as \'Должность\'",
            "РабочаяГруппа as \'Рабочая группа\'"})]
    [View("ПредставительМИРСL", new string[] {
            "Имя as \'Имя\'",
            "Почта as \'Почта\'",
            "Телефон as \'Телефон\'",
            "Должность as \'Должность\'"})]
    public class ПредставительМИРС : ICSSoft.STORMNET.DataObject
    {
        
        private string fИмя;
        
        private string fПочта;
        
        private string fТелефон;
        
        private string fДолжность;
        
        private IIS.Product_47130.РабочаяГруппа fРабочаяГруппа;
        
        // *** Start programmer edit section *** (ПредставительМИРС CustomMembers)

        // *** End programmer edit section *** (ПредставительМИРС CustomMembers)

        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (ПредставительМИРС.Имя CustomAttributes)

        // *** End programmer edit section *** (ПредставительМИРС.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Имя Get start)

                // *** End programmer edit section *** (ПредставительМИРС.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (ПредставительМИРС.Имя Get end)

                // *** End programmer edit section *** (ПредставительМИРС.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Имя Set start)

                // *** End programmer edit section *** (ПредставительМИРС.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (ПредставительМИРС.Имя Set end)

                // *** End programmer edit section *** (ПредставительМИРС.Имя Set end)
            }
        }
        
        /// <summary>
        /// Почта.
        /// </summary>
        // *** Start programmer edit section *** (ПредставительМИРС.Почта CustomAttributes)

        // *** End programmer edit section *** (ПредставительМИРС.Почта CustomAttributes)
        [StrLen(255)]
        public virtual string Почта
        {
            get
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Почта Get start)

                // *** End programmer edit section *** (ПредставительМИРС.Почта Get start)
                string result = this.fПочта;
                // *** Start programmer edit section *** (ПредставительМИРС.Почта Get end)

                // *** End programmer edit section *** (ПредставительМИРС.Почта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Почта Set start)

                // *** End programmer edit section *** (ПредставительМИРС.Почта Set start)
                this.fПочта = value;
                // *** Start programmer edit section *** (ПредставительМИРС.Почта Set end)

                // *** End programmer edit section *** (ПредставительМИРС.Почта Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (ПредставительМИРС.Телефон CustomAttributes)

        // *** End programmer edit section *** (ПредставительМИРС.Телефон CustomAttributes)
        [StrLen(255)]
        public virtual string Телефон
        {
            get
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Телефон Get start)

                // *** End programmer edit section *** (ПредставительМИРС.Телефон Get start)
                string result = this.fТелефон;
                // *** Start programmer edit section *** (ПредставительМИРС.Телефон Get end)

                // *** End programmer edit section *** (ПредставительМИРС.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Телефон Set start)

                // *** End programmer edit section *** (ПредставительМИРС.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (ПредставительМИРС.Телефон Set end)

                // *** End programmer edit section *** (ПредставительМИРС.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Должность.
        /// </summary>
        // *** Start programmer edit section *** (ПредставительМИРС.Должность CustomAttributes)

        // *** End programmer edit section *** (ПредставительМИРС.Должность CustomAttributes)
        [StrLen(255)]
        public virtual string Должность
        {
            get
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Должность Get start)

                // *** End programmer edit section *** (ПредставительМИРС.Должность Get start)
                string result = this.fДолжность;
                // *** Start programmer edit section *** (ПредставительМИРС.Должность Get end)

                // *** End programmer edit section *** (ПредставительМИРС.Должность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредставительМИРС.Должность Set start)

                // *** End programmer edit section *** (ПредставительМИРС.Должность Set start)
                this.fДолжность = value;
                // *** Start programmer edit section *** (ПредставительМИРС.Должность Set end)

                // *** End programmer edit section *** (ПредставительМИРС.Должность Set end)
            }
        }
        
        /// <summary>
        /// Представитель МИРС.
        /// </summary>
        // *** Start programmer edit section *** (ПредставительМИРС.РабочаяГруппа CustomAttributes)

        // *** End programmer edit section *** (ПредставительМИРС.РабочаяГруппа CustomAttributes)
        public virtual IIS.Product_47130.РабочаяГруппа РабочаяГруппа
        {
            get
            {
                // *** Start programmer edit section *** (ПредставительМИРС.РабочаяГруппа Get start)

                // *** End programmer edit section *** (ПредставительМИРС.РабочаяГруппа Get start)
                IIS.Product_47130.РабочаяГруппа result = this.fРабочаяГруппа;
                // *** Start programmer edit section *** (ПредставительМИРС.РабочаяГруппа Get end)

                // *** End programmer edit section *** (ПредставительМИРС.РабочаяГруппа Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредставительМИРС.РабочаяГруппа Set start)

                // *** End programmer edit section *** (ПредставительМИРС.РабочаяГруппа Set start)
                this.fРабочаяГруппа = value;
                // *** Start programmer edit section *** (ПредставительМИРС.РабочаяГруппа Set end)

                // *** End programmer edit section *** (ПредставительМИРС.РабочаяГруппа Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПредставительМИРСE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПредставительМИРСE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПредставительМИРСE", typeof(IIS.Product_47130.ПредставительМИРС));
                }
            }
            
            /// <summary>
            /// "ПредставительМИРСL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПредставительМИРСL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПредставительМИРСL", typeof(IIS.Product_47130.ПредставительМИРС));
                }
            }
        }
    }
}
