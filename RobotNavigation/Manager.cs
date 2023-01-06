using System;
using System.Collections.Generic;
using System.Text;

namespace RobotNavigation
{
    public class Manager 
    {
        public FinalPosition Navigation(String gridSize, String commands)
        {
            FinalPosition finalPosition = new FinalPosition();
            try
            {
                Int32 xVal = 1; // since x initial position is 1
                Int32 yVal = 1; // since y initial position is 1
                String direction = AppConstants.NORTH; // since initial facing direction is North
                Int32 xSizeDefined = Convert.ToInt32(gridSize.Split('*')[0]);
                Int32 ySizeDefined = Convert.ToInt32(gridSize.Split('*')[1]);
                foreach (var item in commands)
                {
                    if (item == 'F')
                    {
                        switch (direction)
                        {
                            case AppConstants.NORTH:
                                {
                                    if (yVal < ySizeDefined)
                                        yVal++;
                                    break;
                                }
                            case AppConstants.SOUTH:
                                {
                                    if (yVal < ySizeDefined)
                                        yVal--;
                                    break;
                                }
                            case AppConstants.EAST:
                                {
                                    if (xVal < xSizeDefined)
                                        xVal++;
                                    break;
                                }
                            case AppConstants.WEST:
                                {
                                    if (xVal < xSizeDefined)
                                        xVal--;
                                    break;
                                }
                        }
                    }
                    else if (item == 'L')
                    {
                        switch (direction)
                        {
                            case AppConstants.NORTH:
                                {
                                    direction = AppConstants.WEST;
                                    break;
                                }
                            case AppConstants.SOUTH:
                                {
                                    direction = AppConstants.EAST;
                                    break;
                                }
                            case AppConstants.EAST:
                                {
                                    direction = AppConstants.NORTH;
                                    break;
                                }
                            case AppConstants.WEST:
                                {
                                    direction = AppConstants.SOUTH;
                                    break;
                                }
                        }
                    }
                    else //Since inputs are always valid, not checking for 'R'
                    {
                        switch (direction)
                        {
                            case AppConstants.NORTH:
                                {
                                    direction = AppConstants.EAST;
                                    break;
                                }
                            case AppConstants.SOUTH:
                                {
                                    direction = AppConstants.WEST;
                                    break;
                                }
                            case AppConstants.EAST:
                                {
                                    direction = AppConstants.SOUTH;
                                    break;
                                }
                            case AppConstants.WEST:
                                {
                                    direction = AppConstants.NORTH;
                                    break;
                                }
                        }
                    }
                }
                finalPosition = new FinalPosition()
                {
                    Direction = direction,
                    XPosition = xVal,
                    YPosition = yVal
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
            return finalPosition;
        }
    }
}
