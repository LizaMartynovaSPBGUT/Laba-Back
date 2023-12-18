namespace API.DTOs
{
	public class CabinetDTO
	{
        public Guid Id { get; set; }
        public string Number { get; set; } = string.Empty;
        public int PlaceCount { get; set; }
        public string CabinetType { get; set; } = string.Empty;
    }
}

