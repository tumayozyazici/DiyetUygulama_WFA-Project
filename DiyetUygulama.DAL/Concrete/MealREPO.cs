﻿using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Concrete
{
    public class MealREPO : BaseREPO<Meal>, IMealREPO
    {
        private readonly DiyetUygulamasiContext db;
        public MealREPO()
        {
            db = new DiyetUygulamasiContext();
        }
        public Meal GetMeal(Meals meal, int memberId)
        {
            return db.Meals.FirstOrDefault(x => x.MealType == meal & x.MemberId == memberId);
        }

        public Meal GetMealByMealIdDate(Meals meal, int memberId, DateTime date)
        {
            return db.Meals.FirstOrDefault(x => x.MealType == meal & x.MemberId == memberId & x.MealDate.Date == date);
        }

        public List<int> GetMealIdListByMealTypeDateID(Meals meal,int memberId)
        {
            return db.Meals.Where(m => m.MealType == meal & m.MemberId == memberId & m.MealDate.Date == DateTime.Now.Date).Select(m => m.MealId).ToList();
        }

        public bool IsThereAnyWithMealDate(Meals meal, int memberId)
        {
            return db.Meals.Any(x => x.MealType == meal && x.MemberId ==memberId && x.MealDate.Date == DateTime.Now.Date);
        }
    }
}
