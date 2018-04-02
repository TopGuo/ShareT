using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ShareT.Common.CacheHelper;
using ShareT.Data;
using ShareT.Data.DbTestEntity_2;
using ShareT.Service;

namespace ShareT.Web.Controllers
{
    public class PersonInfoesController : Controller
    {
        public PersonInfoesController(PersonInfoesService personInfoesService,StudentsInfoService studentsInfoService, IMemoryCache memoryCache)
        {
            _personInfoesService = personInfoesService;
            _studentsInfoService = studentsInfoService;
            _cache = memoryCache;
        }

        protected PersonInfoesService _personInfoesService { get; set; }
        protected StudentsInfoService _studentsInfoService { get; set; }
        private IMemoryCache _cache;

        #region 内存缓存-- 添加/获取缓存
        public IActionResult CacheGetOrCreate()
        {
            var cacheEntry = _cache.GetOrCreate(CacheKeys.DependentCTS, entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(30);
                return DateTime.Now;
            });

            return View("Cache", cacheEntry);
        } 
        #endregion

        // GET: PersonInfoes
        public IActionResult Index()
        {
            var query = _personInfoesService.GetAllPersonInfo();//.Where<PersonInfo>(t=>true);
            
            //
            string cacheEntry;

            // Look for cache key.
            if (!_cache.TryGetValue(CacheKeys.Entry, out cacheEntry))
            {
                var data = _studentsInfoService.GetOneStrdentInfo();
                
                // Key not in cache, so get data.
                cacheEntry = data.Name+ DateTime.Now.ToString();

                // Set cache options.
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep in cache for this time, reset time if accessed.
                    .SetSlidingExpiration(TimeSpan.FromSeconds(30));

                // Save data in cache.
                _cache.Set(CacheKeys.Entry, cacheEntry, cacheEntryOptions);
            }
            ViewBag.Data = cacheEntry;
            return View(query);
        }

        // GET: PersonInfoes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInfo = _personInfoesService.Single<PersonInfo>(m => m.Id == id);
            if (personInfo == null)
            {
                return NotFound();
            }

            return View(personInfo);
        }

        // GET: PersonInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Age")] PersonInfo personInfo)
        {
            if (ModelState.IsValid)
            {
                _personInfoesService.Add(personInfo,true);
                return RedirectToAction(nameof(Index));
            }
            return View(personInfo);
        }

        // GET: PersonInfoes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInfo = _personInfoesService.First<PersonInfo>(m => m.Id == id);
            if (personInfo == null)
            {
                return NotFound();
            }
            return View(personInfo);
        }

        // POST: PersonInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Age")] PersonInfo personInfo)
        {
            if (id != personInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _personInfoesService.Update(personInfo,true);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonInfoExists(personInfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(personInfo);
        }

        // GET: PersonInfoes/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInfo = _personInfoesService.Where<PersonInfo>().SingleOrDefault(t => t.Id == id);
            if (personInfo == null)
            {
                return NotFound();
            }

            return View(personInfo);
        }

        // POST: PersonInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var personInfo = _personInfoesService.Single<PersonInfo>(m => m.Id == id);

            _personInfoesService.Delete(personInfo,true);
            return RedirectToAction(nameof(Index));
        }

        private bool PersonInfoExists(int id)
        {
            return _personInfoesService.Exists<PersonInfo>(e => e.Id == id);
        }
    }
}
