// Copyright Epic Games, Inc. All Rights Reserved.

#include "Git_lfsvcProjectGameMode.h"
#include "Git_lfsvcProjectBall.h"

AGit_lfsvcProjectGameMode::AGit_lfsvcProjectGameMode()
{
	// set default pawn class to our ball
	DefaultPawnClass = AGit_lfsvcProjectBall::StaticClass();
}
