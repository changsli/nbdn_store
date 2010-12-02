using System.Web.Compilation;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.infrastructure
{
    public class WebFormViewFactory : ViewFactory
    {
        WebFormViewPathRegistry path_registry;
        PageFactory page_factory;

        public WebFormViewFactory():this(new StubWebFormViewPathRegistry(),BuildManager.CreateInstanceFromVirtualPath)
        {
        }

        public WebFormViewFactory(WebFormViewPathRegistry path_registry, PageFactory page_factory)
        {
            this.path_registry = path_registry;
            this.page_factory = page_factory;
        }

        public WebView<ViewModel> create_for<ViewModel>(ViewModel model)
        {
            var path_to_view = path_registry.get_path_to_view_that_can_display<ViewModel>();
            var view = (WebView<ViewModel>) page_factory(path_to_view, typeof(WebView<ViewModel>));
            view.model = model;
            return view;
        }
    }
}