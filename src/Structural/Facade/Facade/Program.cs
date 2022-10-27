HotelFacade hotelFacade = new HotelFacade();
hotelFacade.requestBreakfast();
hotelFacade.frontService();

public class FrontDesk
{
    public void payBill()
    {
        Console.WriteLine("Paying the large bill");
    }

}

public class DinnerBar
{
    public void serveDinner()
    {
        Console.WriteLine("Serving dinner");
    }

}

public class BreakfastBar
{
    public void serveBreakfast()
    {
        Console.WriteLine("serving cereal today");
    }
}


public class LaundryCenter
{
    public void pickupClothes()
    {
        Console.WriteLine("Picking up clothes");
    }

    public void washClothes()
    {
        Console.WriteLine(" Washing up clothes");
    }

    public void returnClothes()
    {
        Console.WriteLine("Returning clothes");
    }
}

public class RoomService
{
    public void requestFood()
    {
        Console.WriteLine("Bringing up some food now");
    }
    public void requestMovies()
    {
        Console.WriteLine("Bringing up some movies now");
    }

}

public class HotelFacade
{
    RoomService roomService;
    LaundryCenter laundryCenter;
    DinnerBar dinnerBar;
    BreakfastBar breakfastBar;
    FrontDesk frontDesk;
    public HotelFacade()
    {
        roomService = new RoomService();
        laundryCenter = new LaundryCenter();
        dinnerBar = new DinnerBar();
        breakfastBar = new BreakfastBar();
        frontDesk = new FrontDesk();
    }

    public void frontService()
    {
        frontDesk.payBill();
    }
    public void requestLaundryService()
    {
        laundryCenter.pickupClothes();
        laundryCenter.washClothes();
        laundryCenter.returnClothes();
    }

    public void requestBreakfast()
    {
        breakfastBar.serveBreakfast();
    }

    public void requestDinner()
    {
        dinnerBar.serveDinner();
    }

    public void requestRoomService()
    {
        roomService.requestMovies();
        roomService.requestFood();
    }
}