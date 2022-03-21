package com.ianespana;

public class Usuario {
    private String nombre;
    private String domicilio;
    private String telefono;
    private String rfc;

    /**
     * Construye un nuevo usuario
     * @param nombre El nombre del usuario
     * @param domicilio El domicilio del usuario
     * @param telefono El telefono del usuario
     * @param rfc El RFC del usuario
     */
    public Usuario(String nombre, String domicilio, String telefono, String rfc) {
        this.nombre =  nombre;
        this.domicilio = domicilio;
        this.telefono = telefono;
        this.rfc = rfc;
    }

    /**
     Este método regresa el nombre asociado con el usuario
     @return El nombre del usuario
     */
    public String getNombre(){
        return nombre;
    }

    /**
     Este método regresa el RFC asociado con el usuario
     @return El RFC del usuario
     */
    public String getRfc(){
        return rfc;
    }

    /**
     Este método cambia el domicilio del usuario
     @param domicilio El domcilio del usuario
     */
    public void setDomicilio(String domicilio){
        this.domicilio = domicilio;
    }

    /**
     Este método regresa el domicilio asociado con el usuario
     @return El domicilio del usuario
     */
    public String getDomicilio(){
        return domicilio;
    }

    /**
     Este método cambia el telefono del usuario
     @param telefono El telefono del usuario
     */
    public void setTelefono(String telefono){
        this.telefono = telefono;
    }

    /**
     Este método regresa el telefono asociado con el usuario
     @return El telefono del usuario
     */
    public String getTelefono(){
        return telefono;
    }

    @Override
    public String toString(){
        String info = "Nombre: " + nombre + "\n\t";
        info += "Domicilio: " + domicilio + "\n\t";
        info += "Teléfono: " + telefono + "\n\t";
        info += "RFC: " + rfc;
        return info;
    }
}
