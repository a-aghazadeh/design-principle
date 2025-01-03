using Solid.ISP.Demo01.Resolve;

IFullDevice canonScanLide30= new CanonScanLide30();
IScanDevice hPLaserJet150NW = new HPLaserJet150NW();
IPrintDevice hPLaserJetP4015 = new HPLaserJetP4015();
IScanDevice hPScanJetG4050 = new HPScanJetG4050();

canonScanLide30.Print("Some content");
canonScanLide30.Fax("Some content");
canonScanLide30.Scan("Some content");
canonScanLide30.PhotoCopy("Some content");
Console.WriteLine();

// hPLaserJet150NW.Print("Some content");
// hPLaserJet150NW.Fax("Some content");
hPLaserJet150NW.Scan("Some content");
// hPLaserJet150NW.PhotoCopy("Some content");
Console.WriteLine();

hPLaserJetP4015.Print("Some content");
// hPLaserJetP4015.Fax("Some content");
// hPLaserJetP4015.Scan("Some content");
// hPLaserJetP4015.PhotoCopy("Some content");
Console.WriteLine();

// hPScanJetG4050.Print("Some content");
// hPScanJetG4050.Fax("Some content");
hPScanJetG4050.Scan("Some content");
// hPScanJetG4050.PhotoCopy("Some content");
Console.WriteLine();

Console.ReadLine();
