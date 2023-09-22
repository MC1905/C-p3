using System;
using System.Collections.Generic;

// Klasse voor het vertegenwoordigen van een werknemer
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal LeaveBalance { get; set; }
}

// Klasse voor het vertegenwoordigen van een verlofaanvraag
public class LeaveRequest
{
    public int LeaveRequestId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public bool Approved { get; set; }
}

// Klasse voor het vertegenwoordigen van een manager
public class Manager
{
    public int ManagerId { get; set; }
    public string Name { get; set; }

    // Methode om verlofaanvragen goed te keuren
    public void ApproveLeaveRequest(LeaveRequest request)
    {
        // Voer goedkeuringslogica uit
        request.Approved = true;
    }
}

// Klasse voor het verlofregistratiesysteem
public class LeaveManagementSystem
{
    private List<Employee> employees = new List<Employee>();
    private List<LeaveRequest> leaveRequests = new List<LeaveRequest>();
    private List<Manager> managers = new List<Manager>();

    // Methode om een nieuwe verlofaanvraag in te dienen
    public void SubmitLeaveRequest(int employeeId, DateTime startDate, DateTime endDate, string reason)
    {
        // Voer validatie en opslag van de aanvraag uit
        var request = new LeaveRequest
        {
            LeaveRequestId = leaveRequests.Count + 1,
            EmployeeId = employeeId,
            StartDate = startDate,
            EndDate = endDate,
            Reason = reason,
            Approved = false
        };

        leaveRequests.Add(request);
    }

    // Methode om een manager toe te voegen
    public void AddManager(int managerId, string name)
    {
        managers.Add(new Manager { ManagerId = managerId, Name = name });
    }

    // Methode om een werknemer toe te voegen
    public void AddEmployee(int employeeId, string name, decimal leaveBalance)
    {
        employees.Add(new Employee { EmployeeId = employeeId, Name = name, LeaveBalance = leaveBalance });
    }
}
