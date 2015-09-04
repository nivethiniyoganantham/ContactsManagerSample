using SMEasy.Common;
using SMEasy.Domain.Entity;
using SMEasy.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Xen.Entity;

namespace SMEasy.WebApi.Controllers
{
    public class ContactController : BaseController<Contact>
    {
        [ActionName(ActionName.SaveContact)]
        public HttpResponseMessage ContactSave(ContactViewModel ContactViewModel)
        {
            if (ContactViewModel.IsValid)
            {
                AutoMapper.Mapper.CreateMap<ContactViewModel, Contact>();
                Contact contact = AutoMapper.Mapper.Map<ContactViewModel, Contact>(ContactViewModel);
                return base.Post(contact);
            }
            return Request.CreateResponse<BaseEFEntity>(HttpStatusCode.BadRequest, ContactViewModel);
        }

        [HttpPost]
        [ActionName(ActionName.UpdateContact)]
        public HttpResponseMessage UpdateContact(ContactViewModel ContactViewModel)
        {
            if (ContactViewModel.IsValid)
            {
                AutoMapper.Mapper.CreateMap<ContactViewModel, Contact>();
                Contact contact = AutoMapper.Mapper.Map<ContactViewModel, Contact>(ContactViewModel);
                return base.Put(contact.Id, contact);
            }
            return Request.CreateResponse<BaseEFEntity>(HttpStatusCode.BadRequest, ContactViewModel);
        } 
    }
}
