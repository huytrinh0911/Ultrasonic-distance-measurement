#include "NutNhan.h"
#include "main.h"

uint8_t BTN;
uint8_t BTN_last=1;
uint8_t BTN_filter=1;
uint32_t t_delay;
extern uint8_t cnt;
extern uint8_t cntA;

__weak void NUTNHAN_callback()
{
}
	
void NUTNHAN(GPIO_TypeDef *GPIOx, uint16_t GPIO_Pin)
{
	uint8_t sta= HAL_GPIO_ReadPin(GPIOx,GPIO_Pin);
	if(sta!=BTN_filter)
	{
		BTN_filter=sta;
		t_delay = HAL_GetTick();
	}
	if(HAL_GetTick()- t_delay >= 15)
	{
		BTN = BTN_filter;
  	if(BTN != BTN_last){  //DA nhan hoac tha
			if(BTN==0)  //Nhan nut
			{	
				cntA++;
				BTN_last=BTN;
			}
			else //Tha nut
			{	
				NUTNHAN_callback();
				cnt++;
				BTN_last=BTN;
			}
		}
	}
}
