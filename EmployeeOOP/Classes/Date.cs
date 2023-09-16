﻿using EmployeeOOP.Exceptions;

namespace EmployeeOOP.Classes
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods

        public Date(int day, int month, int year)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }

        private int ValidateDay(int day, int month, int year)
        {
            //Valido si el día ingresado pertenece a un año bisiesto:
            if (month == 2 && day == 29 && IsLeapYear(year)) //   29/2/2023
            {
                return day;
            }

            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                //Exception creation
                throw new DayException(String.Format("El día {0} no es válido para el mes {1}.", day, month));
            }
        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (isLeapYear)
            {
                throw new YearException(String.Format("El año {0} no es bisiesto.", year));
            }
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Exception creation
                throw new YearException(String.Format("El año {0} no es válido.", year));
            }
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12) //Month = 13
            {
                return month;
            }
            else
            {
                //Exception creation
                throw new MonthException(String.Format("El mes {0} no es válido.", month));
            }
        }

        public override string ToString()
        {
            //dia/mes/año
            var dateConcatenated1 = _day + "/" + _month + "/" + _year; // La más vieja y fea
            var dateConcatenated2 = $"{_day:00}/{_month:00}/{_year:0000}"; // Interpolación
            var dateConcatenated3 = String.Format("{0:00}/{1:00}/{2:00}", _day, _month, _year); // Class String.Format

            return dateConcatenated3;
        }

        #endregion

    }
}
