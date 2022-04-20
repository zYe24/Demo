namespace 全局事务过滤器.Models;

public class ErrorViewModel
{
	public string? RequestId { get; set; }

	public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}