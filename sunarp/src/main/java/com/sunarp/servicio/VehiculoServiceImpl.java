package com.sunarp.servicio;

import java.util.ArrayList;
import java.util.List;

import javax.jws.WebService;

import com.sunarp.modelo.Vehiculo;


@WebService(endpointInterface="com.sunarp.servicio.VehiculoService")
public class VehiculoServiceImpl implements VehiculoService {

	
	private List<Vehiculo> vehiculos;
	
	public VehiculoServiceImpl(){
		
		vehiculos = obtenerVehiculos();
		
	}
	
	
	
	
	public List<Vehiculo> obtenerVehiculos(){
	
	List<Vehiculo> lista = new ArrayList<Vehiculo>();
	
	
	 Vehiculo Vehiculo1 = new Vehiculo();
     Vehiculo1.setCodigo("B2P258");
     Vehiculo1.setMarca("Toyota");
     Vehiculo1.setModelo("Auris");
     Vehiculo1.setMotor("1600");
     Vehiculo1.setAfabrica("2011");
     Vehiculo1.setColor("Negro");
     Vehiculo1.setChazis("ZR5752045");
   
     
     Vehiculo Vehiculo2 = new Vehiculo();
     Vehiculo2.setCodigo("B2P258");
     Vehiculo2.setMarca("Toyota");
     Vehiculo2.setModelo("Auris");
     Vehiculo2.setMotor("1600");
     Vehiculo2.setAfabrica("2011");
     Vehiculo2.setColor("Negro");
     Vehiculo2.setChazis("ZR5752045");
	
     Vehiculo Vehiculo3 = new Vehiculo();
     Vehiculo3.setCodigo("B2P258");
     Vehiculo3.setMarca("Toyota");
     Vehiculo3.setModelo("Auris");
     Vehiculo3.setMotor("1600");
     Vehiculo3.setAfabrica("2011");
     Vehiculo3.setColor("Negro");
     Vehiculo3.setChazis("ZR5752045");
     
     lista.add(Vehiculo1);
     lista.add(Vehiculo2);
     lista.add(Vehiculo3);
     
	return lista;
	
	}	
	
	
	



	public Vehiculo consultarVehiculo(String codigoVehiculo) {
		for (Vehiculo vehiculo : vehiculos) 
		{
			if(vehiculo.getCodigo().equals(codigoVehiculo))
			{
				return vehiculo;
			}
		}

        return null;
	}
	
}
