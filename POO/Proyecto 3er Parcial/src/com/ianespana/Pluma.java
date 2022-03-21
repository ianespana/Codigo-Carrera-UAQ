package com.ianespana;

public class Pluma {
    private boolean plumaDeEntrada;
    private boolean estadoSemaforo; // Verdadera = Verde, Falso = Rojo

    /**
     Este metodo genera una nueva pluma de entrada o salida
     @param plumaDeEntrada Diferencía una pluma de entrada (verdadero) de una pluma de salida (falso)
     */
    public Pluma(boolean plumaDeEntrada){
        this.plumaDeEntrada = plumaDeEntrada;
        estadoSemaforo = true;
    }

    /**
     Este metodo abre la pluma por 6 segundos y luego la cierra
     */
    public void abrirPluma(){
        System.out.println("Abriendo pluma");
        try {
            Thread.sleep(1000);
            System.out.println("Pluma abierta, puedes pasar (esperando 6 segundos)");
            Thread.sleep(6000);
            System.out.println("Cerrando pluma");
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.out.println("Pluma cerrada");
    }

    /**
     Este metodo cambia el color del semaforo asociado a la pluma
     @param estadoSemaforo El estado del semaforo. Verdadero para verde, falso para rojo
     */
    public void setSemaforo(boolean estadoSemaforo){
        if (!plumaDeEntrada) return;
        this.estadoSemaforo = estadoSemaforo;
    }
}
