using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blog.Api.Data;
using Blog.Api.Models;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Posts1Controller : ControllerBase
    {
        private readonly BlogApiContext _context;

        public Posts1Controller(BlogApiContext context)
        {
            _context = context;
        }

        // GET: api/Posts1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Posts>>> GetPost()
        {
            return await _context.Post.ToListAsync();
        }

        // GET: api/Posts1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Posts>> GetPosts(int id)
        {
            var posts = await _context.Post.FindAsync(id);

            if (posts == null)
            {
                return NotFound();
            }

            return posts;
        }

        // PUT: api/Posts1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosts(int id, Posts posts)
        {
            if (id != posts.Id)
            {
                return BadRequest();
            }

            _context.Entry(posts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Posts1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Posts>> PostPosts(Posts posts)
        {
            _context.Post.Add(posts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosts", new { id = posts.Id }, posts);
        }

        // DELETE: api/Posts1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosts(int id)
        {
            var posts = await _context.Post.FindAsync(id);
            if (posts == null)
            {
                return NotFound();
            }

            _context.Post.Remove(posts);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostsExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
