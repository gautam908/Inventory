using BookStore.Entity;
using BookStore.Models;
using BookStore.Repository;
using BookStore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        #region Fields
        private readonly ICategoryService _categoryService;

        #endregion
        #region ctor
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        [HttpGet("GetCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Category>))]
        public async Task<IActionResult> GetCategory()
        {
            return Ok(await _categoryService.GetCategory());
        }

        [HttpGet("GetCategoryById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        public async Task<IActionResult> GetCategoryById(int categoryid)
        {
            return Ok(await _categoryService.GetCategoryById(categoryid));
        }

        [HttpPost("AddCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        public async Task<IActionResult> AddCategory(CategoryDto request)
        {
            return Ok(await _categoryService.AddCategory(request));
        }

        [HttpPatch("UpdateCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        public async Task<IActionResult> UpdateCategory(CategoryDto request)
        {
            return Ok(await _categoryService.UpdateCategory(request));
        }

        [HttpDelete("DeleteCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        public async Task<IActionResult> DeleteCategory(int categoryid)
        {
            return Ok(await _categoryService.DeleteCategory(categoryid));
        }

    }
}
