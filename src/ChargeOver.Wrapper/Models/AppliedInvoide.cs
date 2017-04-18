using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class AppliedInvoide
	{
		[JsonProperty("invoice_id")]
		public int InvoiceId { get; set; }
		[JsonProperty("applied")]
		public float Applied { get; set; }
	}
}