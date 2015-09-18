﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIToggledComponents : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Toggle(IntPtr l) {
		try {
			UIToggledComponents self=(UIToggledComponents)checkSelf(l);
			self.Toggle();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activate(IntPtr l) {
		try {
			UIToggledComponents self=(UIToggledComponents)checkSelf(l);
			pushValue(l,self.activate);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activate(IntPtr l) {
		try {
			UIToggledComponents self=(UIToggledComponents)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.MonoBehaviour> v;
			checkType(l,2,out v);
			self.activate=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deactivate(IntPtr l) {
		try {
			UIToggledComponents self=(UIToggledComponents)checkSelf(l);
			pushValue(l,self.deactivate);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_deactivate(IntPtr l) {
		try {
			UIToggledComponents self=(UIToggledComponents)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.MonoBehaviour> v;
			checkType(l,2,out v);
			self.deactivate=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIToggledComponents");
		addMember(l,Toggle);
		addMember(l,"activate",get_activate,set_activate,true);
		addMember(l,"deactivate",get_deactivate,set_deactivate,true);
		createTypeMetatable(l,null, typeof(UIToggledComponents),typeof(UnityEngine.MonoBehaviour));
	}
}