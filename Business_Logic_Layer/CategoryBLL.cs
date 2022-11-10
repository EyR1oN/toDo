using Business_Logic_Layer.AutoMapper;
using Business_Logic_Layer.Interfaces;
using Business_Logic_Layer.Models;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class CategoryBLL : ICategoryBLL
    {

        private ICategoryDAL _DAL;

        public CategoryBLL(ICategoryDAL DAL)
        {
            _DAL = DAL;
        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            var categoriesEntity = await _DAL.GetCategories();
            List<CategoryModel> categoriesModel = MyAutoMapper<Category, CategoryModel>.MapList(categoriesEntity);

            return categoriesModel;
        }

        public async Task<IActionResult> PostCategory(CategoryModel catedory)
        {
            Category categoryEntity = MyAutoMapper<CategoryModel, Category>.Map(catedory);
            return await _DAL.PostCategory(categoryEntity);
        }


        public async Task<IActionResult> DeleteCategory(int id)
        {
            return await _DAL.DeleteCategory(id);
        }

        public async Task<IActionResult> PutCategory(CategoryModel categoryModel)
        {
            Category categoryEntity = MyAutoMapper<CategoryModel, Category>.Map(categoryModel);
            return await _DAL.PutCategory(categoryEntity);
        }
    }
}
