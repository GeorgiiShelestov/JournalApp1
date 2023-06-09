﻿using System;
using System.Collections.Generic;
using System.Text;
using JournalApp.ViewModels.Base;
namespace JournalApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title = "Анализ статистики JournalApp";
        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //if (Equals(_Title, value)) return;
            //_Title = value;
            //OnPropertyChanged();

            //Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
        #endregion


        #region Status : string - Статус программы
        /// <summary>Статус программы</summary>
        private string _Status = "Ready!";
        /// <summary>статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion
    }
}