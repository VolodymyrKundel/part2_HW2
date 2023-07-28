namespace part2_HW2
{
    public interface IManagementCars
    {
        public Task GetCarName(HttpContext context);
        public Task GetCarEngine(HttpContext context);
        public Task GetCarAge(HttpContext context);
    }
}
