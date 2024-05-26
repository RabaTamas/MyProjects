package hu.bme.aut.android.recipes.feature.food

import android.app.AlertDialog
import android.app.Dialog
import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import androidx.appcompat.app.AppCompatDialogFragment
import hu.bme.aut.android.recipes.R
import hu.bme.aut.android.recipes.databinding.DialogNewFoodBinding

class AddFoodDialogFragment : AppCompatDialogFragment() {

    private lateinit var binding: DialogNewFoodBinding
    private lateinit var listener: AddFoodDialogListener

    interface AddFoodDialogListener {
        fun onFoodAdded(food: String?)
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)
        binding = DialogNewFoodBinding.inflate(LayoutInflater.from(context))

        listener = context as? AddFoodDialogListener
            ?: throw RuntimeException("Activity must implement the AddFoodDialogListener interface!")
    }

    override fun onCreateDialog(savedInstanceState: Bundle?): Dialog {
        return AlertDialog.Builder(requireContext())
            .setTitle(R.string.new_food)
            .setView(binding.root)
            .setPositiveButton(R.string.ok) { _, _ ->
                listener.onFoodAdded(
                    binding.NewFoodDialogEditText.text.toString()
                )
            }
            .setNegativeButton(R.string.cancel, null)
            .create()
    }
}