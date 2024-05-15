package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.ArrayList;
import java.util.List;

@Entity
@Table(name = "clinica")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class Clinica {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private Long cnpj;
    private String nome;

    @OneToMany
    private List<Empresa> empresa = new ArrayList<>();

    @OneToMany
    private List<Medico> medico = new ArrayList<>();
}
