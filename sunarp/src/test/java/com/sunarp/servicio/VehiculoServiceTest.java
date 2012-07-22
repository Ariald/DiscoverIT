package com.sunarp.servicio;

import static org.junit.Assert.*;

import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.sunarp.modelo.Vehiculo;

public class VehiculoServiceTest {
	
	//  Sujeto de prueba es ?
	
	VehiculoService service;
	
	public VehiculoServiceTest(){
		
		ApplicationContext fabrica = new ClassPathXmlApplicationContext("/fabrica-text.xml");
		
		
		service = fabrica.getBean("vehiculoService",VehiculoService.class);
		
		
	}
	
	//ahora buscamos la placa por vehiculo 
	@Test
	public void deberiaBuscarPorPlaca(){
		Vehiculo vehiculo = service.consultarVehiculo("b2p258");
		assertNotNull(vehiculo);
	}
	

}
