using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sean1.Pages.Shared;

public class AddSoloUser : PageModel
{
    public void OnGet()
    {
        
    }


    [BindProperty]
    public ConstructorApplication _app { get; set; }
    
    
    public void OnPost()
    {
        
        //в ссылке на апишку через $ указываю элементы которые хочу отправить, ниже пример
        var test = _app.Birthday;
        
        
        HttpClient client = new HttpClient();
        var response = client.PostAsync("Тут должна быть ссылка на api, но аппишка не нету у меня", null);
    }
}