package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.relational.core.mapping.Table;

import java.util.ArrayList;
import java.util.List;

@Entity
@Table("cargo")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class Cargo {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;

    @OneToMany
    @Column(name = "risco_ocupacional_id")
    private List<RiscoOcupacional> riscoOcupacional = new ArrayList<>();
}
