using LabsManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.Domain
{
    public static class CommonData
    {
        public static string GenerateTitleTopText(LabTemplate labTemplate)
        {
            string text = "Министерство образования Республики Беларусь\n" +
                "Учреждение образования «Гомельский государственный технический университет\n" +
                "имени П.О. Сухого»\n\n\n\n\nКафедра «Промышленная электроника»\n\n\n\n\n" +
                $"Лабораторная работа №{labTemplate.Number}\n«{labTemplate.Theme}»\n\n" +
                $"по дисциплине «Электронные промышленные устройства»\n\n\n\n\n\n\n\n\n\n";

            return text;
        }

        public static string GenerateTitleRightText(LabTemplate labTemplate)
        {
            string text = $"Выполнил:\nСтудент группы {labTemplate.StudentGroup}:\n" +
                $"{labTemplate.StudentFullName}\nПринял преподаватель:\n" +
                $"{labTemplate.TeacherFullName}\n\n\n\n\n\n";

            return text;
        }

        public static string GeneratePurposeText(LabTemplate labTemplate)
        {
            string text = $"Цель работы:\n{labTemplate.Purpose}";

            return text;
        }
    }
}
