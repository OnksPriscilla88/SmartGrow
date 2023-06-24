Public Class AutomatedPlantGrowingDevice

Private DeviceStatus As Boolean
Private PlantName As String
Private PlantType As String
Private WaterLevel As Double
Private Temperature As Double
Private LightLevel As Integer
Private SoilMoisture As Double
Private FeedingSchedule As Date
Private FertilizingSchedule As Date

Public Sub New(ByVal pName As String, ByVal pType As String, ByVal wLevel As Double, 
ByVal tLevel As Double, ByVal lLevel As Integer, ByVal sMoisture As Double, ByVal fSchedule As Date, ByVal fFertilize As Date)
	DeviceStatus = True
	PlantName = pName
	PlantType = pType
	WaterLevel = wLevel
	Temperature = tLevel
	LightLevel = lLevel
	SoilMoisture = sMoisture
	FeedingSchedule = fSchedule
	FertilizingSchedule = fFertilize
End Sub

Public Sub CheckPlantStatus()
	If (DeviceStatus = True) Then
		If (WaterLevel > 0.3 And Temperature > 25 And LightLevel > 7 And SoilMoisture > 0.2) Then
			MsgBox("Plant Status: Healthy")
		Else
			MsgBox("Plant Status: Unhealthy")
		End If
	Else
		MsgBox("Device is not active.")
	End If
End Sub

Public Sub WaterPlant()
	If (DeviceStatus = True) Then
		If (WaterLevel < 0.3) Then
			WaterLevel = WaterLevel + 0.2
		Else
			MsgBox("Plant is already sufficiently watered")
		End If
	Else
		MsgBox("Device is not active.")
	End If
End Sub

Public Sub FeedPlant()
	If (DeviceStatus = True) Then
		If (FeedingSchedule < Date.Now) Then
			MsgBox("Plant is being fed.")
			FeedingSchedule = FeedingSchedule.AddDays(7)
		End If
	Else
		MsgBox("Device is not active.")
	End If
End Sub

Public Sub FertilizePlant()
	If (DeviceStatus = True) Then
		If (FertilizingSchedule < Date.Now) Then
			MsgBox("Plant is being fertilized")
			FertilizingSchedule = FertilizingSchedule.AddDays(14)
		End If
	Else
		MsgBox("Device is not active.")
	End If
End Sub

Public Sub MonitorEnvironment()
	If (DeviceStatus = True) Then
		MsgBox("Temperature Level: " & Temperature & vbCrLf & "Light Level: " & LightLevel & vbCrLf & "Soil Moisture Level: " & SoilMoisture)
	Else
		MsgBox("Device is not active.")
	End If
End Sub

Public Sub ActivatePlantDevice()
	DeviceStatus = True
	MsgBox("Plant device is now activated.")
End Sub

Public Sub DeactivatePlantDevice()
	DeviceStatus = False
	MsgBox("Plant device is now deactivated.")
End Sub

End Class