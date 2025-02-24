; DANIEL GHERGHEL. - v8.1

For Each CAB Assembly

If CAB.CLASS = 5 || CAB.CLASS = 6 || CAB.CLASS = 7 || CAB.CLASS = 8 || CAB.CLASS = 9 || CAB.CLASS = 21 || CAB.CLASS = 22 || CAB.CLASS = 23 Then
	Exit
End If

If (Cab.Class = ASM_CLASS_UPPER OR Cab.Class = ASM_CLASS_BASE OR Cab.Class = ASM_CLASS_VANITY) and Cab.Type = ASM_TYPE_FILLER Then

		public FINTOP_PRICE<crncy> = 45
		public FLTSHLF_PRICE<crncy> = 65
		public FINTOP_MIN_PRICE<crncy> = 150
		public CSV15_PRICE<crncy> = 30
		public CSV2_PRICE<crncy> = 30
		public CSV3_PRICE<crncy> = 30
		public CSV_over_4Feet<crncy> = 25
		public CSV_PRICE<crncy> = 30
		public FPT_PRICE<crncy> = 18
		public LCRWN_PRICE<crncy> = 35
		public LCRWN_MIN_PRICE<crncy> = 75
		public FSF_price<crncy> = 40
		public FSF_min_price<crncy> = 35
		public LITE_PRICE<crncy> = 45
		public LITE_PRICE_RETURN<crncy> = 25
		public FIN_TOP_OVER_FE<crncy> = 25
		sqFtVal = 144
		fourFeetVal = 48

	If Name = 'FINTOP*' Then
	PRICE := ((CAB.DZ*CAB.DX)/sqFtVal)* FINTOP_PRICE
		If PRICE < FINTOP_MIN_PRICE Then
		PRICE := FINTOP_MIN_PRICE
		End If


	Else If Name = 'FLTSHLF*' Then
	PRICE := ((CAB.DZ*CAB.DX)/sqFtVal)* FLTSHLF_PRICE
		If PRICE < FINTOP_MIN_PRICE Then
			PRICE := FINTOP_MIN_PRICE
		End If





	Else If Name = 'FPT*' Then
	PRICE := ((CAB.DY*CAB.DZ)/sqFtVal) * FPT_PRICE


	Else If Name = 'FSF*' Then
	PRICE := ((CAB.DX * CAB.DY)/sqFtVal) * FSF_price
	If PRICE < FSF_min_price Then
		PRICE := FSF_min_price
	End If


	Else If Name = 'LCRWN*' or Name = 'lcrwn*' or Name = 'L CRWN*' or Name = 'l crwn*' Then
	PRICE := ((CAB.DX * CAB.DY)/sqFtVal) * LCRWN_PRICE

	If PRICE < LCRWN_MIN_PRICE Then
		PRICE := LCRWN_MIN_PRICE
	End If


	Else If Name = 'LITE*' or Name = 'lite*' Then
	PRICE := ((CAB.DX * CAB.DY)/sqFtVal)* LITE_PRICE
		If PRICE < LCRWN_MIN_PRICE Then
			PRICE := LCRWN_MIN_PRICE
		End If

	If CAB.DZ >= 3 Then
	PRICE := ((CAB.DX * CAB.DY * CAB.DZ)/sqFtVal) * LITE_PRICE_RETURN
	End If

	Else If Name == 'CSV-3/4*' Then
	PRICE := ((CAB.DY*CAB.DX*CAB.DZ)/sqFtVal) * CSV_PRICE
		
	Else If Name == 'CSV-1 1/2*' Then
			
		If CAB.DY < 48 Then
		PRICE := ((Cab.DY*CAB.DX*CAB.DZ)/sqFtVal) * CSV15_PRICE
		Else
			If CAB.DY >= 48 Then
			PRICE := ((Cab.DY*CAB.DX*CAB.DZ)/sqFtVal) * FIN_TOP_OVER_FE
			End If
		End If
		
	Else If Name == 'CSV-2x*' Then

			If CAB.DY < 48 Then
			PRICE := ((CAB.DY*CAB.DX*CAB.DZ)/sqFtVal) * CSV2_PRICE
			Else
				If CAB.DY >= 48 Then
				PRICE := ((CAB.DY*CAB.DX*CAB.DZ)/sqFtVal) * FIN_TOP_OVER_FE
				End If
			End If
			
	Else If Name == 'CSV-3x*' Then
		
			If CAB.DY < 48 Then
			PRICE := ((CAB.DY*CAB.DX*CAB.DZ)/sqFtVal) * CSV3_PRICE
			Else
				If CAB.DY >= 48 Then
				PRICE := ((CAB.DY*CAB.DX*CAB.DZ)/sqFtVal) * FIN_TOP_OVER_FE
				End If
			End If
			
	Else If Name == 'CSV-*' Then
		PRICE := ((CAB.DY*CAB.DX*CAB.DZ)/sqFtVal) * CSV15_PRICE

	End If
	End If
	End If
	End If
	End If
	End If
	End If
	End If
	End If
	End If
	End If
End If
