using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace WebApiInterface.CheckAlive
{
    public class WebApi
    {
        private readonly static string dllPath = @"D:\SVN\WarmSoft\PetSitting.ServiceProxy\bin\Debug\netcoreapp2.2\PetSitting.ServiceProxy.dll";

        private static List<string> allowTypeList = new List<string>() { "IAppProxy","IInventoryProxy","IMainProxy","IMessagesProxy","InPatientProxy",
        "IRegisterProxy","ISysSettingProxy","ITreatmentProxy"};

        public static void ParseDll()
        {
            Assembly a = Assembly.LoadFile(dllPath);
            Type[] types = a.GetTypes();
            foreach (Type type in types)
            {

                if (!type.IsPublic)
                {
                    continue;
                }

                if (!type.FullName.Contains("PetSitting"))
                {
                    continue;
                }

                bool access = false;
                foreach (var allowType in allowTypeList)
                {
                    if (type.FullName.Contains(allowType))
                    {
                        access = true;
                    }
                }

                if (!access)
                    continue;

                object instance = Activator.CreateInstance(type);

                MemberInfo[] members = type.GetMembers(BindingFlags.Public
                                                      | BindingFlags.Instance
                                                      | BindingFlags.InvokeMethod);
                foreach (MemberInfo member in members)
                {
                    bool isAbstractClass = false;
                    var fullName = member.DeclaringType.FullName;
                    if (!fullName.Contains("PetSitting"))
                    {
                        continue;
                    }
                    var methodName = member.Name;
                    MethodInfo mi = type.GetMethod(methodName);
                    if (mi == null)
                    {
                        Console.WriteLine(methodName + "is not exists");
                        continue;
                    }
                    ParameterInfo[] pars = mi.GetParameters();
                    List<object> parameters = new List<object>();
                    foreach (ParameterInfo p in pars)
                    {
                        if (p.ParameterType == typeof(int))
                        {
                            parameters.Add(0);
                        }
                        else if (p.ParameterType == typeof(string))
                        {
                            parameters.Add("a");
                        }
                        else if (p.ParameterType == typeof(bool))
                        {
                            parameters.Add(true);
                        }
                        else if (p.ParameterType.IsAbstract)
                        {
                            Console.WriteLine(p.ParameterType + "是抽象类型");
                            isAbstractClass = true;
                            break;
                        }
                        else if (p.ParameterType == typeof(byte[]))
                        {
                            parameters.Add(new byte[5]);
                        }
                        else
                        {
                            object instanceInputPara = Activator.CreateInstance(p.ParameterType);
                            parameters.Add(instanceInputPara);
                        }
                    }
                    if (isAbstractClass)
                        continue;

                    var ret = mi.Invoke(instance, parameters.ToArray());
                    Console.WriteLine("[" + DateTime.Now + "]" + "函数是:" + methodName + "-----返回值是:" + ret);
                }



            }
        }
    }
}
