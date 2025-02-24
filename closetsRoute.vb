;Modifies Back for closets - DANIEL G.

 For Each UB Part

 If Cab.Class = ASM_CLASS_CLOSET Then
  If Cab.ConstID = AsmConstID('CLOSET-3-4-BACK') Then



	Dim Bck_notch as New Dado
		Bck_notch.VISIBLE = True
		
		Bck_notch.DX = 3
		Bck_notch.DY = :DX
		Bck_notch.DZ = :DZ/2
		
		Bck_notch.X = :X
		Bck_notch.Y = :DY
		Bck_notch.Z = 0
		
		Bck_notch.AX<deg> = 0
		Bck_notch.AY<deg> = 0
		Bck_notch.AZ<deg> = -90
		Bck_notch.TOOLID<int> = 12
		

		
		Dim lt_notch as New Dado
			lt_notch.VISIBLE = True
			
			lt_notch.DX = 3
			lt_notch.DY = 19.05mm
			lt_notch.DZ = 19.05mm
			
			lt_notch.X = :DX - DY
			lt_notch.Y = :DY
			lt_notch.Z = 0
			
			lt_notch.AX<deg> = 0
			lt_notch.AY<deg> = 0
			lt_notch.AZ<deg> = -90
			
			
		Dim rt_notch as New Dado
		rt_notch.VISIBLE = True
		
		rt_notch.DX = 3
		rt_notch.DY = 19.05mm
		rt_notch.DZ = 19.05mm
		
		rt_notch.X = :X
		rt_notch.Y = :DY
		rt_notch.Z = 0
		
		rt_notch.AX<deg> = 0
		rt_notch.AY<deg> = 0
		rt_notch.AZ<deg> = -90

			

		
		
  End If
 End If
