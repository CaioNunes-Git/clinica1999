package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.ArrayList;
import java.util.List;

@Entity
@Table(name = "risco_ocupacional")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class RiscoOcupacional {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;

    @OneToMany
    @Column(name = "tipo_risco_id")
    private List<TipoRisco> tipoRisco = new ArrayList<>();
}
