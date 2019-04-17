using Abp.Application.Services.Dto;

namespace ANKO.AgEmailSender.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

