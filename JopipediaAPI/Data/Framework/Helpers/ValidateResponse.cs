using Microsoft.AspNetCore.Mvc;

namespace tsprojectsAPI.Data.Framework.Helpers
{
    public static class ValidateResponse
    {
        public static async Task<IActionResult> Validate(ControllerBase controller, dynamic response)
        {
            if(response.IsNotFound)
                return controller.NotFound(new {response.Data, response.Message});

            if(response.IsBadRequest)
                return controller.BadRequest(new {response.Data, response.Message});

            return controller.Ok(new { response.Data, response.Message, response.Meta });
        }
    }
}