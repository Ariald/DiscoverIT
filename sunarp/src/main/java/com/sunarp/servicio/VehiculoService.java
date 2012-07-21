package com.sunarp.servicio;

import javax.jws.WebParam;
import javax.jws.WebService;

import com.sunarp.modelo.Vehiculo;

@WebService

public interface VehiculoService {

	public Vehiculo consultarVehiculo(@WebParam(name = "codigoVehiculo") String codigo);
	
}
