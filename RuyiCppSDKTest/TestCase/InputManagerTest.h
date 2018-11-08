#pragma once

#include "Layer0Test.h"
#include "BaseUnitTest.h"

#define WINVER 0x0501
#include <windows.h>
#include <process.h>

using namespace Ruyi;
using namespace Ruyi::SDK;
using namespace std;

class InputManagerTest : BaseUnitTest
{
public:
	InputManagerTest(RuyiSDKContext::Endpoint endpoint = RuyiSDKContext::Endpoint::Console, string remoteAddress = "localhost");

	void InputManagerReceiveInputMessage();

	//to test when destroying ruyi SDk, if the receiving thread will end
	void SubscribeTimeoutTest();

	unsigned int SubscriberMessage();

	void SubStateChangeHandler2(std::string topic, apache::thrift::TBase* msg);

private:
	void SubscribeListenerOne(std::string topic, apache::thrift::TBase* msg);
};