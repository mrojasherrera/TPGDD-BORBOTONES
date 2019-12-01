# TPGDD-BORBOTONES

 La fecha del sistema se toma del archivo app.config
 se debe incluir "using System.Configuration" en el formulario en que lo voy a usar
 para setear la app.config se hace
    doble clik sobre en el explorador de soluciones sobre Properties e incluir
    el concepto en la grilla que se presenta en nuestro caso: fechaSistema
    esto se hace por única vez.
 para acceder a la variable:
    var fecha_sistema = Properties.Settings.Default.fechaSistema
    
