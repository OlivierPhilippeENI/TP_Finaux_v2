using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web;
using TP01M05.BO;
using TP01M05.Models;
using TP01M05.Persistance;

namespace TP01M05.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View(Persistance.Persistance.Instance.Chats);
        }

        public ActionResult Create()
        {
            ChatCreateViewModel vm = new ChatCreateViewModel();
            vm.Couleurs.Add(new Couleur() { Id = 1, Name = "Blanc" });
            vm.Couleurs.Add(new Couleur() { Id = 2, Name = "Noir" });
            vm.Couleurs.Add(new Couleur() { Id = 3, Name = "Rouge" });
            vm.Couleurs.Add(new Couleur() { Id = 4, Name = "Bleu" });
            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(ChatCreateViewModel vm)
        {
            try
            {
                vm.Chat.Couleur = vm.Couleurs.FirstOrDefault(x => x.Id == vm.IdCouleur);
                Persistance.Persistance.Instance.Chats.Add(vm.Chat);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(vm);
            }


        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            Chat chat = Persistance.Persistance.Instance.Chats.FirstOrDefault(x => x.Id == id);
            if (chat != null)
            {
                return View(chat);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            Chat chat = Persistance.Persistance.Instance.Chats.FirstOrDefault(x => x.Id == id);
            if (chat != null)
            {
                return View(chat);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Chat chat = Persistance.Persistance.Instance.Chats.FirstOrDefault(x => x.Id == id);
                Persistance.Persistance.Instance.Chats.Remove(chat);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}