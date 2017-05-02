using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectN2.Models;

namespace ProjectN2.Controllers
{
    public class NeuralNetworksController : Controller
    {
        private readonly NeuralNetworkContext _context;

        public NeuralNetworksController(NeuralNetworkContext context)
        {
            _context = context;    
        }

        // GET: NeuralNetworks
        public async Task<IActionResult> Index()
        {
            return View(await _context.NeuralNetworks.ToListAsync());
        }

        // GET: NeuralNetworks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var neuralNetworks = await _context.NeuralNetworks
                .SingleOrDefaultAsync(m => m.id == id);
            if (neuralNetworks == null)
            {
                return NotFound();
            }

            return View(neuralNetworks);
        }

        // GET: NeuralNetworks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NeuralNetworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,numOfNeurons,numOfLayers")] NeuralNetworks neuralNetworks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(neuralNetworks);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(neuralNetworks);
        }

        // GET: NeuralNetworks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var neuralNetworks = await _context.NeuralNetworks.SingleOrDefaultAsync(m => m.id == id);
            if (neuralNetworks == null)
            {
                return NotFound();
            }
            return View(neuralNetworks);
        }

        // POST: NeuralNetworks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,numOfNeurons,numOfLayers")] NeuralNetworks neuralNetworks)
        {
            if (id != neuralNetworks.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(neuralNetworks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NeuralNetworksExists(neuralNetworks.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(neuralNetworks);
        }

        // GET: NeuralNetworks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var neuralNetworks = await _context.NeuralNetworks
                .SingleOrDefaultAsync(m => m.id == id);
            if (neuralNetworks == null)
            {
                return NotFound();
            }

            return View(neuralNetworks);
        }

        // POST: NeuralNetworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var neuralNetworks = await _context.NeuralNetworks.SingleOrDefaultAsync(m => m.id == id);
            _context.NeuralNetworks.Remove(neuralNetworks);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool NeuralNetworksExists(int id)
        {
            return _context.NeuralNetworks.Any(e => e.id == id);
        }
    }
}
